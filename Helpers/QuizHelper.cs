using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Quiz_App.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quiz_App.Helpers
{
    class QuizHelper
    {
        List<Question> History;
        List<Question> Geography;
        List<Question> Space;
        List<Question> Engineer;
        List<Question> Programming;
        List<Question> Business;
        public string GetTopicDescription(string topic)
        {
            string topicDescription = "";
            if(topic == "History")
            {
                topicDescription = "History"; 
            }
            else if(topic == "Geography")
            {
                topicDescription = "Geography";
            }
            else if (topic == "Space")
            {
                topicDescription = "";
            }
            else if (topic == "Engineer")
            {
                topicDescription = "Engineer";
            }
            else if (topic == "Programming")
            {
                topicDescription = "Programming";
            }
            else if (topic == "Business")
            {
                topicDescription = "Business";
            }
            return topicDescription;
            
        }
        public List<Question> GetQuizQuestions(string topic)
        {
            List<Question> quizList = new List<Question>();
            if(topic == "History")
            {
                InitializeHistory();
                quizList = History;
            }else if (topic == "Geography")
            {
                InitializeGeography();
                quizList = Geography;
            }
            else if (topic == "Space")
            {
                InitializeSpace();
                quizList = Space;
            }
            else if (topic == "Engineer")
            {
                InitializeEngineer();
                quizList = Engineer;
            }
            else if (topic == "Programming")
            {
                InitializeProgramming();
                quizList = Programming;
            }
            else if (topic == "Programming")
            {
                InitializeBusiness();
                quizList = Business;
            }
            return quizList;
        }
        void InitializeHistory()
        {
            History = new List<Question>();

            History.Add(new Question { QuizQuestion = "The Berlin Wall fell, the Galileo Spacecraft is launched by NASA and George H. W. Bush is sworn in as the 41st President of the United States", Answer = "1989s", OptionA = "1989s", OptionB = "1990s", OptionC = "1991s", OptionD = "1992" });
            History.Add(new Question { QuizQuestion = "The one-child policy was introduced in China, Margaret Thatcher became the first female Prime Minister of the UK, Apocalypse Now was released in cinemas.", Answer = "1979s", OptionA = "1979s", OptionB = "1980s", OptionC = "1981s", OptionD = "1982" });
            History.Add(new Question { QuizQuestion = "The Titanic sunk, the Republic of China was established, the south pole was discovered.", Answer = "1912s", OptionA = "1910s", OptionB = "1911s", OptionC = "1912s", OptionD = "1913s" });
            History.Add(new Question { QuizQuestion = "Actor James Dean died in a car accident, Anthony Eden became Prime Minister in the UK, the Vietnam war began between the Democratic Republic of Vietnam and the Republic of Vietnam.", Answer = "1955s", OptionA = "1954s", OptionB = "1955s", OptionC = "1956s", OptionD = "1957s" });
            History.Add(new Question { QuizQuestion = "The first Woodstock festival was held, Richard Nixon became president of the USA, the first humans landed on the moon.", Answer = "1969s", OptionA = "1967s", OptionB = "1968s", OptionC = "1969s", OptionD = "1979s" });

        }
        void InitializeGeography()
        {
            Geography = new List<Question>();

            //Geography.Add(new Question { QuizQuestion = "", Answer = "", OptionA = "", OptionB = "", OptionC = "", OptionD = "" });
            Geography.Add(new Question { QuizQuestion = "Which river flows through Paris?", Answer = "River Seine", OptionA = "Rever Loire", OptionB = "Rever Seine", OptionC = "Rever Rhône", OptionD = "Rever Garonne" });
            Geography.Add(new Question { QuizQuestion = "In which country is the UK’s highest mountain, Ben Nevis?", Answer = "Scotland", OptionA = "China", OptionB = "Wales", OptionC = "England", OptionD = "Scotland" });
            Geography.Add(new Question { QuizQuestion = "Mount Vesuvius overlooks which modern Italian city?", Answer = "Naples", OptionA = "Salerno", OptionB = "Naples", OptionC = "Cosenza", OptionD = "Latina" });
            Geography.Add(new Question { QuizQuestion = "What is the capital of Mozambique?", Answer = "Maputo", OptionA = "Beira", OptionB = "Chimoio", OptionC = "Tete", OptionD = "Maputo" });
            Geography.Add(new Question { QuizQuestion = "What is the capital of Namibia?", Answer = "Windhoek", OptionA = "Cape Town", OptionB = "Windhoek", OptionC = "Khorixas", OptionD = "Rundu" });
        }
        void InitializeSpace()
        {
            Space.Add(new Question { QuizQuestion = "Which statement describes the atmosphere of the planet correctly?", Answer = "Venus is mostly carbon dioxide", OptionA = "Venus is mostly carbon dioxide", OptionB = "Mercury is mostly nitrogen", OptionC = "Earth is mostly oxygen", OptionD = "Saturn is mostly helium" });
            Space.Add(new Question { QuizQuestion = "How many planets are there in our solar system?", Answer = "Eight", OptionA = "Nine", OptionB = "Ten", OptionC = "Eleven", OptionD = "Eight" });
            Space.Add(new Question { QuizQuestion = "To weigh roughly two-thirds less than what you do on Earth, which planet would you be on?", Answer = "Mars", OptionA = "Uranus", OptionB = "Mars", OptionC = "Venus", OptionD = "Jupiter" });
            Space.Add(new Question { QuizQuestion = " How long does it take for light from the Sun to reach Earth", Answer = "8 minutes", OptionA = "1 minute", OptionB = "8 minutes", OptionC = "Instantaneous", OptionD = "24 hours" });
            Space.Add(new Question { QuizQuestion = "It takes the Sun 225-250 million years to do one revolution of the Milky Way Galaxy. How fast does the Sun travel?", Answer = "220km in a second", OptionA = "220km in a second" , OptionB = "220km in an minute", OptionC = "220 km in a hour", OptionD = "220km in a year"  });
        }
        void InitializeEngineer()
        {
            Engineer.Add(new Question { QuizQuestion = "Which bridge, built between 1924 and 1932, is the widest long-span bridge in the world?", Answer = "The Sydney Harbour Bridge", OptionA = "The Sydney Harbour Bridge, Australia", OptionB = "The Akashi Kaikyo Bridge, Japan", OptionC = "The Golden Gate Bridge, US", OptionD = "Jiangyin Suspension Bridge, China" });
            Engineer.Add(new Question { QuizQuestion = "What is the world's tallest free standing structure?", Answer = "CN tower, Toronto, Canada", OptionA = "Eiffel Tower, Paris, France", OptionB = "CN tower, Toronto, Canada", OptionC = "Sears Tower, Chicago, US", OptionD = "Taipei 101, Taipei, Taiwan" });
            Engineer.Add(new Question { QuizQuestion = "What is the tallest residential building?", Answer = "Q1, Australia", OptionA = "Q1, Australia", OptionB = "West Point Tower, the Netherlands", OptionC = "Hyperion Tower, South Korea", OptionD = "Millennium Tower, Vienna" });
            Engineer.Add(new Question { QuizQuestion = "What is the largest hole ever dug in the Earth?", Answer = "Kennecott's Bingham Copper Mine, Utah, USA", OptionA = "The Panama Canal, Panama", OptionB = "Kennecott's Bingham Copper Mine, Utah, USA", OptionC = "The Big Hole, Kimberley, South Africa", OptionD = "Excavation for the West Edmonton Mall, Alberta, Canada" });
            Engineer.Add(new Question { QuizQuestion = "How much earth was moved to dig the Panama canal?", Answer = "184 million cubic metres", OptionA = "18 million cubic metres", OptionB = "84 million cubic metres", OptionC = "184 million cubic metres", OptionD = "1800 million cubic metres " });
        }
        void InitializeProgramming()
        {
            Programming.Add(new Question { QuizQuestion = "What year was the world’s first mobile phone handset released for sale?", Answer = "1983", OptionA = "1979", OptionB = "1983", OptionC = "1991", OptionD = "2001" });
            Programming.Add(new Question { QuizQuestion = "On average how many SMS messages are sent via mobile phone per phone user every day?", Answer = "2.5", OptionA = "0.5", OptionB = "4.0", OptionC = "2.5", OptionD = "5.5" });
            Programming.Add(new Question { QuizQuestion = "Who designed the ‘first’ small computer for home use?", Answer = "John Blankenbaker", OptionA = "John Blankenbaker", OptionB = "Steve Wozniak", OptionC = "Chuck Peddle", OptionD = "Steve Leininger" });
            Programming.Add(new Question { QuizQuestion = "When was the first email sent over the internet?", Answer = "1971", OptionA = "1961", OptionB = "1965", OptionC = "1971", OptionD = "1988" });
            Programming.Add(new Question { QuizQuestion = "When was the internet created?", Answer = "1968", OptionA = "1968", OptionB = "1972", OptionC = "1982", OptionD = "1995" });
        }
        void InitializeBusiness()
        {
            Business.Add(new Question { QuizQuestion = "What is the name of a person who owns part of a corporation?", Answer = "Shareholder", OptionA = "Stakeholder", OptionB = "Trust Agent", OptionC = "Shareholder", OptionD = "Chairman" });
            Business.Add(new Question { QuizQuestion = "How many people can be involved in a partnership?", Answer = "2-20", OptionA = "2-10", OptionB = "2-15", OptionC = "2-5", OptionD = "2-20" });
            Business.Add(new Question { QuizQuestion = "What are the owners of private and public limited companies called?", Answer = "Shareholders", OptionA = "Stakeholders", OptionB = "Managers", OptionC = "Board of directors", OptionD = "Shareholders" });
            Business.Add(new Question { QuizQuestion = "Which of the following is a drawback for an entrepreneur setting up a business as a sole trader?", Answer = "Unlimited liability", OptionA = "Profit is shared", OptionB = "Financial accounts are kept private", OptionC = "Limited liability", OptionD = "Unlimited liability" });
            Business.Add(new Question { QuizQuestion = "Which of the following types of business can advertise shares for sale to the general public?", Answer = "Public limited company", OptionA = "Sole trader", OptionB = "Partnership", OptionC = "Private limited company", OptionD = "Public limited company" });
        }
    }
}