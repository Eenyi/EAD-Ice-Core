namespace IceCore.Models {
    public class SubscriberRepository {
        public bool AddSubscriber(Subscriber subscriber) {
            try{
                if (subscriber != null) {
                    var context = new IceCoreContext();
                    context.Subscribers.Add(subscriber);
                    context.SaveChanges();
                    return true;
                }
                else {
                    return false;
                }
            }
            catch {
                return false;
            }
        }

        public bool IsSubscriberExist(Subscriber subscriber) {
            try {
                if (subscriber != null) {
                    var context = new IceCoreContext();
                    var Subscriber = context.Subscribers.Where(s=>s.UserName.Equals(subscriber.UserName)).FirstOrDefault();
                    if (Subscriber != null) {
                        if (subscriber.SubscriberId == subscriber.SubscriberId && subscriber.Password == Subscriber.Password) {
                            return true;
                        }
                        else {
                            return false;
                        }
                    }
                    else {
                        return false;
                    }
                }
                else {
                    return false;
                }
            }
            catch {
                return false;
            }
        }
    }
}
