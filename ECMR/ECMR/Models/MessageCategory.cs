using System.Collections.ObjectModel;

namespace ECMR.Models
{
    public class MessageCategory
    {
        public string Title { get; set; }
        public string Detail { get; set; }
        public int NumOfCategory { get; set; }
        public string ImageSource { get; set; }


        public static ObservableCollection<MessageCategory> LoadCategories()
        {
            ObservableCollection<MessageCategory> msgCategories = new ObservableCollection<MessageCategory>();

            msgCategories.Add( new MessageCategory()
            {
                Title = "1",
                Detail = "Μετάβαση σε φαρμακείο ή επίσκεψη στον γιατρό, εφόσον αυτό συνιστάται μετά από σχετική επικοινωνία.",
                ImageSource =  "information.png",
                NumOfCategory = 1
            });
            msgCategories.Add( new MessageCategory()
            {
                Title = "2",
                Detail = "Μετάβαση σε εν λειτουργία κατάστημα προμηθειών αγαθών πρώτης ανάγκης, όπου δεν είναι δυνατή η αποστολή τους.",
                ImageSource =  "supermarket.png",
                NumOfCategory = 2
            });
            msgCategories.Add( new MessageCategory()
            {
                Title = "3",
                Detail = "Μετάβαση στην τράπεζα, στο μέτρο που δεν είναι δυνατή η ηλεκτρονική συναλλαγή.",
                ImageSource =  "money.png",
                NumOfCategory = 3
            });
            msgCategories.Add( new MessageCategory()
            {
                Title = "4",
                Detail = "Κίνηση για παροχή βοήθειας σε ανθρώπους που βρίσκονται σε ανάγκη.",
                ImageSource =  "care.png",
                NumOfCategory = 4
            });
            msgCategories.Add( new MessageCategory()
            {
                Title = "5",
                Detail = "Μετάβαση σε τελετή (π.χ. κηδεία, γάμος, βάφτιση ή ανάλογες τελετές) υπό τους όρους που προβλέπει ο νόμος.",
                ImageSource =  "party.png",
                NumOfCategory = 5
            });
            msgCategories.Add( new MessageCategory()
            {
                Title = "6",
                Detail = "Σωματική άσκηση σε εξωτερικό χώρο ή κίνηση με κατοικίδιο ζώο, ατομικά ή ανά δύο άτομα, τηρώντας στην τελευταία αυτή περίπτωση την αναγκαία απόσταση 1,5 μέτρου.",
                ImageSource =  "jogging.png",
                NumOfCategory = 6
            });


            return msgCategories;
        }
    }

  
}
