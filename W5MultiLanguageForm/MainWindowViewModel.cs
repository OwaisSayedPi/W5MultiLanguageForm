using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W5MultiLanguageForm
{
    public class MainWindowViewModel:BaseViewModel
    {
        public List<Language> Language { get; set; }
        public List<Question> DisplayQuestion { get; set; }
        public List<Question> Questions { get; set; }
        private Language selectedLanguage;
        public Language SelectedLanguage
        {
            get
            {
                return selectedLanguage;
            }
            set
            {
                if (selectedLanguage != value)
                {
                    List<Question> temp = Questions.Where(x => x.LanguageID == value.LanguageID).ToList();
                    for (int i = 0; i < temp.Count; i++)
                    {
                        temp[i].Answer = DisplayQuestion[i].Answer;
                    }
                    DisplayQuestion = temp;
                    OnPropertyChanged(nameof(DisplayQuestion));
                }
            }
        }
        public MainWindowViewModel()
        {
            Language = new List<Language>() {
                new Language() { LanguageID = 1, LanguageString = "English" },
                new Language() { LanguageID = 2, LanguageString = "French" },
                new Language() { LanguageID = 3, LanguageString = "Marathi" }};

            Questions = new List<Question>() {
                new Question() { QuestionID = 1, LanguageID = 1 , QuestionString = "What's Your Name?" },
                new Question() { QuestionID = 1, LanguageID = 2 , QuestionString = "Comment tu t'appelles?" },
                new Question() { QuestionID = 1, LanguageID = 3 , QuestionString = "तुझं नाव काय आहे?" },
                new Question() { QuestionID = 2, LanguageID = 1 , QuestionString = "Where do you live?" },
                new Question() { QuestionID = 2, LanguageID = 2 , QuestionString = "où habitez-vous?" },
                new Question() { QuestionID = 2, LanguageID = 3 , QuestionString = "तुम्ही कुठे राहता?" },
                new Question() { QuestionID = 3, LanguageID = 1 , QuestionString = "What do you want?" },
                new Question() { QuestionID = 3,  LanguageID = 2 , QuestionString = "Qu'est-ce que vous voulez?" },
                new Question() { QuestionID = 3,  LanguageID = 3 , QuestionString = "आपण काय करू इच्छिता?" }
            };
            DisplayQuestion = Questions.Where(x => x.LanguageID == 1).ToList();
        }
    }
}
