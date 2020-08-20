using CBT1.Model;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CBT1.ViewModels
{
    public class QuestionViewModel : BindableBase
    {
        public QuestionViewModel()
        {
            _question = new QuestionModel[]
          {
                new QuestionModel() {Question="2 x 2", CorrectAnswer="4", Answer1="4", Answer2="3", Answer3="2", Answer4="8", QuestionNo="1" },
                new QuestionModel() {Question="square root of 64", CorrectAnswer="8", Answer1="16", Answer2="4", Answer3="126", Answer4="8", QuestionNo="2" },
                new QuestionModel() {Question="what's the name of this app developer", CorrectAnswer="Suzy", Answer1="Nddy", Answer2="Peace", Answer3="RJ", Answer4="Suzy", QuestionNo="3" },
                new QuestionModel() {Question="What's the code snippet to add a full property", CorrectAnswer="fullprop", Answer1="prop", Answer2="fullprop", Answer3="fpop", Answer4="propg", QuestionNo="4" },
                new QuestionModel() {Question="What's the sode snippet for a constructor", CorrectAnswer="ctor", Answer1="cnst", Answer2="cstor", Answer3="cor", Answer4="ctor", QuestionNo="5" },
                new QuestionModel() {Question="Symbol of C Sharp", CorrectAnswer="C#", Answer1="C", Answer2="CS", Answer3="C#", Answer4="C!",QuestionNo="6" },
                new QuestionModel() {Question="16 x 8", CorrectAnswer="128", Answer1="168", Answer2="168", Answer3="201", Answer4="142",QuestionNo="7" },
                new QuestionModel() {Question="Cube root of 64?", CorrectAnswer="4", Answer1="4", Answer2="8", Answer3="2", Answer4="16", QuestionNo="8" },
                new QuestionModel() {Question="2 + 8 + 14", CorrectAnswer="24", Answer1="26", Answer2="24", Answer3="18", Answer4="30", QuestionNo="9" },
                new QuestionModel() {Question="square root of 625", CorrectAnswer="25", Answer1="15", Answer2="32", Answer3="25", Answer4="18", QuestionNo="10" }
           };
            PickQuestion(index);
            // _regionManager = regionManager;


            NextCommand = new DelegateCommand(NextAction);
            NextCommand = new DelegateCommand(Endquestion);
            PrevCommand = new DelegateCommand(PrevAction);
            Btn1 = new DelegateCommand(PickSpecQuestion);
        }

        private void PickQuestion(int index)
        {
            var question = _question[index];
            Question = question.Question;
            QuestionNo = question.QuestionNo;
            Option1 = question.Answer1;
            Option2 = question.Answer4;
            Option3 = question.Answer2;
            Option4 = question.Answer3;
        }

        private void PickSpecQuestion()
        {
            PickQuestion(1);

        }
        private void Endquestion()
        {
            if (Question== "square root of 625")
            {
                MessageBox.Show("You have reached the end of this test questions. you can either click Prev or Submit button");
            }
        }

        private void Navigate(string uri)
        {
            _regionManager.RequestNavigate("contentArea", uri);
        }
        private void NextAction()
        {
            if (SelectedOption1 == SelectedOption2 == SelectedOption3 == SelectedOption4)
            {
                MessageBox.Show("you haven't selected any option", "Notification");
            }
            PickQuestion(++index);
        }

        private void PrevAction()
        {
            if (SelectedOption1 == SelectedOption2 == SelectedOption3 == SelectedOption4)
            {
                MessageBox.Show("you haven't selected any option", "Notification");
            }
            PickQuestion(--index);
        }

        private void MarkQuestion()
        {
            var question = _question[index];
           // if (SelectedOption1.IsChecked)
           // {

           // }
        }


        public QuestionModel[] _question;
        public int index = 0;
        public DelegateCommand NextCommand { get; }
        public DelegateCommand PrevCommand { get; }
        public DelegateCommand<string> NavigateCommand { get; set; }
        public DelegateCommand Btn1 { get; }
        public bool SelectedOption1 { get; set; }
        public bool SelectedOption2 { get; set; }
        public bool SelectedOption3 { get; set; }
        public bool SelectedOption4 { get; set; }
        private readonly IRegionManager _regionManager;

        private string fquestion;
        public string Question
        {
            get { return fquestion; }
            set {
               // if (value!= fquestion)
               // {
                    fquestion = value;
                OnPropertyChanged(nameof(Question));
                      //  SetValue(value);
              // }
                }
        }


        private string questionNo;

        public string QuestionNo
        {
            get { return questionNo; }
            set {
               if (value != questionNo)
               {

                    questionNo = value;
                    OnPropertyChanged(nameof(QuestionNo));
                  //  SetProperty(ref questionNo, value);
               }
                 }
        }


        private string option1;

        public string Option1
        {
            get { return option1; }
            set {
               // if (value!= option1)
               // {
                    option1 = value;
                    SetProperty(ref option1, value);
               // }
                 }
        }
        private string option2;

        public string Option2
        {
            get { return option2; }
            set {
               // if (value != option2)
              //  {
                    option2 = value;
                    SetProperty(ref option2, value);
               // }
            }
        }

        private string option3 ;

        public string Option3
        {
            get { return option3; }
            set {
               // if (value != option3)
               // {
                    option3 = value;
                    SetProperty(ref option3, value);
               // }
            }
        }

        private string option4;  //field

        public string Option4
        {
            get { return option4; }
            set {
               // if (value != option4)
               // {
                    option4 = value;
                    SetProperty(ref option4, value);
               // }
            }
        }

        private string[] options = { "correct", "incorrect" };

        public string[] Options
        {
            get { return options; }
            set { options = value; }
        }


    }
}
