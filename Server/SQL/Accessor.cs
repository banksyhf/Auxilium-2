using System.Linq;
using System;

namespace Auxilium_Server.SQL
{
    internal static class Accessor
    {
        public static string ConnectionString { get; set; }

        public static User GetUser(int id)
        {
            DatabaseDataContext db = new DatabaseDataContext(ConnectionString);
            return db.Users.FirstOrDefault(x => x.Id == id);
        }

        public static User GetUser(string username)
        {
            DatabaseDataContext db = new DatabaseDataContext(ConnectionString);
            return db.Users.FirstOrDefault(x => x.Username.ToLower() == username.ToLower());
        }

        public static User GetUser(string username, string password)
        {
            DatabaseDataContext db = new DatabaseDataContext(ConnectionString);
            return db.Users.FirstOrDefault(x =>
                (x.Username.ToLower() == username.ToLower() || x.Email == username.ToLower())
                && x.Password == password.ToLower());
        }

        public static User[] GetUserFromPartialName(string partialName)
        {
            DatabaseDataContext db = new DatabaseDataContext(ConnectionString);
            return db.Users.Where(x => x.Username.Contains(partialName.ToLower())).ToArray();
        }

        public static bool InsertUser(string username, string password, string email)
        {
            DatabaseDataContext db = new DatabaseDataContext(ConnectionString);

            bool exists = db.Users.Any(x => x.Username == username.ToLower() || x.Email == email.ToLower());
            if (exists)
                return false;

            User user = new User()
            {
                Id = 0,
                Username = username,
                Password = password.ToLower(),
                Email = email.ToLower(),
            };

            db.Users.InsertOnSubmit(user);
            db.SubmitChanges();

            return db.Users.Contains(user);
        }

        public static Channel[] GetChannels()
        {
            DatabaseDataContext db = new DatabaseDataContext(ConnectionString);
            return db.Channels.ToArray();
        }

        public static bool UpdateRank(string username, int points, byte rank)
        {
            DatabaseDataContext db = new DatabaseDataContext(ConnectionString);
            User user = db.Users.FirstOrDefault(x => x.Username.ToLower() == username.ToLower());

            if (user != null)
            {
                user.Points = points;
                user.Rank = rank;

                db.SubmitChanges();

                return true;
            }

            return false;
        }

        public static bool AddNewSuggestion(string username, string text)
        {
            DatabaseDataContext db = new DatabaseDataContext(ConnectionString);

            SuggestionTable suggestion = new SuggestionTable()
            {
                Suggestion = text,
                Username = username
            };

            db.SuggestionTables.InsertOnSubmit(suggestion);
            db.SubmitChanges();

            return db.SuggestionTables.Contains(suggestion);
        }

        public static bool AddPrivateMessage(int fromId, int toId, string subject, string message)
        {
            PrivateMessageInfo pm = new PrivateMessageInfo()
            {
                FromID = fromId,
                ToID = toId,
                Subject = subject,
                TimeSent = DateTime.UtcNow,
                Message = message,
                TimeRead = DateTime.FromOADate(0)
            };

            DatabaseDataContext db = new DatabaseDataContext(ConnectionString);
            
            db.PrivateMessageInfos.InsertOnSubmit(pm);
            db.SubmitChanges();

            return db.PrivateMessageInfos.Contains(pm);
        }

        public static PrivateMessageInfo[] GetPrivateMessages(string username)
        {
            User user = GetUser(username);
            return GetPrivateMessages(user.Id);
        }
        public static PrivateMessageInfo[] GetPrivateMessages(int userId)
        {
            DatabaseDataContext db = new DatabaseDataContext(ConnectionString);

            return db.PrivateMessageInfos.Where(x =>
                x.FromID == userId ||
                x.ToID == userId)
                .ToArray();
        }
    }
}