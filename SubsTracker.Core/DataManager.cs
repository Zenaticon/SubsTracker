using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace SubsTracker.Core
{

    public class DataManager
    {
        private readonly string UsersFilePath = "users.json";
        private readonly string SubscriptionsFilePath = "subscriptions.json";

        public List<User> GetUsers()
        {
            if (!File.Exists(UsersFilePath))
            {
                File.WriteAllText(UsersFilePath, "[]");
            }

            string json = File.ReadAllText(UsersFilePath);
            return JsonConvert.DeserializeObject<List<User>>(json);
        }

        public async Task AddUser(User user)
        {
            List<User> users = GetUsers();

            User _user = new User
            {
                Username = user.Username,
                Email = user.Email,
                Password = user.Password
            };

            // Generate a new unique ID for the user
            do
            {
                _user.Id = Guid.NewGuid();
            } while (users.Exists(u => u.Id == _user.Id));

            // Add the user to the list of users
            users.Add(_user);

            await SaveUsers(users);
            users = null;
            _user = null;
        }

        public async Task UpdateUser(User user)
        {
            List<User> users = GetUsers();
            int index = users.FindIndex(u => u.Id == user.Id);

            users[index] = user;

            await SaveUsers(users);
            users = null;
            index = 0;
        }

        public async Task DeleteUser(User user)
        {
            List<User> users = GetUsers();

            User _user = users.Find(u => u.Id == user.Id);

            users.Remove(_user);

            await SaveUsers(users);
            users = null;
            _user = null;
        }

        public async Task SaveUsers(List<User> users)
        {
            string json = JsonConvert.SerializeObject(users);
            await Task.Run(() =>
            {
                // Perform CPU-bound work on a background thread here...
                File.WriteAllText(UsersFilePath, json);
            });
            json = null;
        }

        //AddItem(subscriptionid,userid,"Netflix", "netflix.png", 10.2, "eur", true, 5, null);

        public List<Subscription> GetSubscriptions()
        {
            if (!File.Exists(SubscriptionsFilePath))
            {
                File.WriteAllText(SubscriptionsFilePath, "[]");
            }

            string json = File.ReadAllText(SubscriptionsFilePath);

            List<Subscription> subscriptions = JsonConvert.DeserializeObject<List<Subscription>>(json);

            //subscriptions = subscriptions.FindAll(s => s.UserId == user.Id);

            return subscriptions;
        }

        public async Task AddSubscription(User user, Subscription subscription)
        {
            List<Subscription> subscriptions = GetSubscriptions();

            Subscription _subscription = new Subscription
            {
                UserId = user.Id,
                Provider = subscription.Provider,
                Icon = subscription.Icon,
                Amount = subscription.Amount,
                Currency = subscription.Currency,
                Type = subscription.Type,
                Day = subscription.Day,
                Month = subscription.Month
            };

            // Generate a new unique ID for the user
            do
            {
                _subscription.Id = Guid.NewGuid();
            } while (subscriptions.Exists(s => s.Id == _subscription.Id));

            // Add the user to the list of users
            subscriptions.Add(_subscription);

            await SaveSubscriptions(subscriptions);
            subscriptions = null;
            _subscription = null;
        }

        public async Task UpdateSubscription(Subscription subscription)
        {
            List<Subscription> subscriptions = GetSubscriptions();

            int index = subscriptions.FindIndex(s => s.Id == subscription.Id);

            subscriptions[index] = subscription;

            await SaveSubscriptions(subscriptions);
            subscriptions = null;
            index = 0;
        }
        public async Task DeleteSubscription(Subscription subscription)
        {
            List<Subscription> subscriptions = GetSubscriptions();

            Subscription _subscription = subscriptions.Find(s => s.Id == subscription.Id);

            subscriptions.Remove(_subscription);

            await SaveSubscriptions(subscriptions);
            subscriptions = null;
            _subscription = null;
        }

        public async Task SaveSubscriptions(List<Subscription> subscriptions)
        {
            string json = JsonConvert.SerializeObject(subscriptions);
            await Task.Run(() =>
            {
                File.WriteAllText(SubscriptionsFilePath, json);
            });
            json = null;
        }
    }
}
