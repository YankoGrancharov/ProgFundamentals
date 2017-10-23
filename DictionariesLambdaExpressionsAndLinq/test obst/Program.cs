//////using System;
//////using System.Collections.Generic;
//////using System.Linq;

//////namespace Phonebook
//////{
//////    public class Phonebook
//////    {
//////        static void Main(string[] args)
//////        {
//////            Dictionary<string, string> phonebook = new Dictionary<string, string>();

//////            bool canContinue = true;

//////            while (canContinue)
//////            {
//////                string[] command = Console.ReadLine().Split();

//////                switch (command[0])
//////                {
//////                    case "A":
//////                        AddToPB(phonebook, command);
//////                        break;
//////                    case "S":
//////                        SearchPB(phonebook, command);
//////                        break;
//////                    case "END":
//////                        canContinue = false;
//////                        break;
//////                }
//////            }
//////        }

//////        private static void SearchPB(Dictionary<string, string> phonebook, string[] command)
//////        {
//////            if (phonebook.ContainsKey(command[1]))
//////            {
//////                Console.WriteLine("{0} -> {1}", command[1], phonebook[command[1]]);
//////            }
//////            else
//////            {
//////                Console.WriteLine($"Contact {command[1]} does not exist.");
//////            }
//////        }

//////        private static void AddToPB(Dictionary<string, string> phonebook, string[] command)
//////        {

//////            if (phonebook.ContainsKey(command[1]))
//////            {
//////                phonebook[command[1]] = command[2];
//////            }
//////            else
//////            {
//////                phonebook.Add(command[1], command[2]);
//////            }
//////        }
//////    }
//////}
////using System;
////using System.Collections.Generic;
////using System.Linq;

////namespace PhonebookUpgrade
////{
////    public class PhonebookUpgrade
////    {
////        static void Main(string[] args)
////        {
////            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();

////            bool canContinue = true;

////            while (canContinue)
////            {
////                string[] command = Console.ReadLine().Split();

////                switch (command[0])
////                {
////                    case "A":
////                        AddToPB(phonebook, command);
////                        break;
////                    case "S":
////                        SearchPB(phonebook, command);
////                        break;
////                    case "ListAll":
////                        ListAllEntries(phonebook);
////                        break;
////                    case "END":
////                        canContinue = false;
////                        break;
////                }
////            }
////        }

////        private static void ListAllEntries(SortedDictionary<string, string> phonebook)
////        {
////            foreach (KeyValuePair<string, string> entry in phonebook)
////            {
////                Console.WriteLine($"{entry.Key} -> {entry.Value}");
////            }
////        }

////        private static void SearchPB(SortedDictionary<string, string> phonebook, string[] command)
////        {
////            if (phonebook.ContainsKey(command[1]))
////            {
////                Console.WriteLine("{0} -> {1}", command[1], phonebook[command[1]]);
////            }
////            else
////            {
////                Console.WriteLine($"Contact {command[1]} does not exist.");
////            }
////        }

////        private static void AddToPB(SortedDictionary<string, string> phonebook, string[] command)
////        {

////            if (phonebook.ContainsKey(command[1]))
////            {
////                phonebook[command[1]] = command[2];
////            }
////            else
////            {
////                phonebook.Add(command[1], command[2]);
////            }
////        }
////    }
////}

//////using System;
//////using System.Collections.Generic;
//////using System.Linq;

//////namespace UserLogs
//////{
//////    public class UserLogs
//////    {
//////        static void Main(string[] args)
//////        {
//////            SortedDictionary<string, Dictionary<string, int>> users = new SortedDictionary<string, Dictionary<string, int>>();

//////            string command = Console.ReadLine();

//////            while (command != "end")
//////            {
//////                SavDataProces(command, users);
//////                command = Console.ReadLine();
//////            }

//////            PrintingResulData(users);
//////        }

//////        private static void PrintingResulData(SortedDictionary<string, Dictionary<string, int>> users)
//////        {
//////            foreach (KeyValuePair<string, Dictionary<string, int>> usr in users)
//////            {
//////                Console.WriteLine($"{usr.Key}:");
//////                int counter = 0;
//////                foreach (var item in usr.Value)
//////                {
//////                    Console.Write($"{item.Key} => {item.Value}");
//////                    if (counter < usr.Value.Count - 1)
//////                    {
//////                        Console.Write(", ");
//////                        counter++;
//////                    }
//////                    else
//////                    {
//////                        Console.WriteLine(".");
//////                    }
//////                }
//////            }
//////        }

//////        private static void SavDataProces(string command, SortedDictionary<string, Dictionary<string, int>> users)
//////        {
//////            List<string> lineData = command.Split(' ').ToList();
//////            string userName = lineData[2].Substring(5);
//////            string iP = lineData[0].Substring(3);

//////            if (users.ContainsKey(userName))
//////            {
//////                if (users[userName].ContainsKey(iP))
//////                {
//////                    users[userName][iP] += 1;
//////                }
//////                else
//////                {
//////                    users[userName].Add(iP, 1);
//////                }
//////            }
//////            else
//////            {
//////                users.Add(userName, new Dictionary<string, int> { { iP, 1 } });
//////            }
//////        }
//////    }
//////}

//////////////using System;
//////////////using System.Collections.Generic;
//////////////using System.Linq;

//////////////namespace FixEmails
//////////////{
//////////////    public class FixEmails
//////////////    {
//////////////        static void Main(string[] args)
//////////////        {
//////////////            bool canContinue = true;
//////////////            Dictionary<string, string> eMails = new Dictionary<string, string>();

//////////////            while (canContinue)
//////////////            {
//////////////                string name = Console.ReadLine();
//////////////                string emailAdress = "";
//////////////                if (name == "stop")
//////////////                {
//////////////                    canContinue = false;
//////////////                    break;
//////////////                }
//////////////                else
//////////////                {
//////////////                    emailAdress = Console.ReadLine();
//////////////                }

//////////////                bool isUsUkEmail = false;
//////////////                string mailTL = emailAdress.ToLower();

//////////////                if (emailAdress.Contains(".us") || emailAdress.Contains(".uk"))
//////////////                {
//////////////                    isUsUkEmail = true;
//////////////                }

//////////////                if (isUsUkEmail == false)
//////////////                {
//////////////                    if (eMails.ContainsKey(name))
//////////////                    {
//////////////                        eMails[name] = emailAdress;
//////////////                    }
//////////////                    else
//////////////                    {
//////////////                        eMails.Add(name, emailAdress);
//////////////                    }
//////////////                }
//////////////            }
//////////////            foreach (KeyValuePair<string, string> entry in eMails)
//////////////            {
//////////////                Console.WriteLine($"{entry.Key} -> {entry.Value}");
//////////////            }
//////////////        }
//////////////    }
//////////////}

////using System;
////using System.Collections.Generic;
////using System.Linq;
////namespace AMinerTask
////{
////    public class AMinerTask
////    {
////        static void Main(string[] args)
////        {
////            bool canContinue = true;
////            Dictionary<string, int> mats = new Dictionary<string, int>();

////            while (canContinue)
////            {
////                string material = Console.ReadLine();

////                int quantity = 0;
////                if (material == "stop")
////                {
////                    canContinue = false;
////                    PrintSortedResults(mats);
////                    break;
////                }
////                else
////                {
////                    quantity = int.Parse(Console.ReadLine());
////                }

////                if (mats.ContainsKey(material))
////                {
////                    mats[material] += quantity;
////                }
////                else
////                {
////                    mats.Add(material, quantity);
////                }

////            }
////        }

////        private static void PrintSortedResults(Dictionary<string, int> mats)
////        {

////            foreach (KeyValuePair<string, int> materials in mats)
////            {
////                Console.WriteLine($"{materials.Key} -> {materials.Value}");
////            }

////        }
////    }
////}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//namespace HandsOfCards
//{
//    public class HandsOfCards
//    {
//        static void Main(string[] args)
//        {
//            bool canContinue = true;
//            Dictionary<string, int> scores = new Dictionary<string, int>();
//            Dictionary<string, string> rawData = new Dictionary<string, string>();

//            while (canContinue)
//            {

//                string[] input = Console.ReadLine().Split(':').ToArray();
//                string name = input[0];

//                if (name == "JOKER")
//                {
//                    canContinue = false;
//                    break;
//                }

//                if (rawData.ContainsKey(name))
//                {
//                    rawData[name] += input[1];
//                }
//                else
//                {
//                    rawData.Add(name, input[1]);
//                }

//            }

//            foreach (KeyValuePair<string, string> item in rawData)
//            {
//                List<string> ManCard = new List<string>();

//                ManCard = item.Value.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Distinct().ToList();

//                int sumOfHand = 0;
//                foreach (string card in ManCard)
//                {
//                    sumOfHand += PoindC(card);
//                }

//                if (scores.ContainsKey(item.Key))
//                {
//                    scores[item.Key] += sumOfHand;
//                }
//                else
//                {
//                    scores.Add(item.Key, sumOfHand);
//                }
//            }

//            foreach (KeyValuePair<string, int> score in scores)
//            {
//                Console.WriteLine($"{score.Key}: {score.Value}");
//            }
//        }

//        private static int PoindC(string card)
//        {
//            string power = card[0].ToString();
//            string type = card[card.Length - 1].ToString();
//            if (power == "1")
//            {
//                power = "10";
//            }
//            int powerAsNumber = 0;
//            int typeAsNumber = 0;
//            bool nPower = int.TryParse(power, out powerAsNumber);

//            if (nPower == false)
//            {
//                switch (power)//J, Q, K, A
//                {
//                    case "J":
//                        powerAsNumber = 11;
//                        break;
//                    case "Q":
//                        powerAsNumber = 12;
//                        break;
//                    case "K":
//                        powerAsNumber = 13;
//                        break;
//                    case "A":
//                        powerAsNumber = 14;
//                        break;
//                }
//            }

//            switch (type)//S -> 4, H-> 3, D -> 2, C -> 1
//            {
//                case "S":
//                    typeAsNumber = 4;
//                    break;
//                case "H":
//                    typeAsNumber = 3;
//                    break;
//                case "D":
//                    typeAsNumber = 2;
//                    break;
//                case "C":
//                    typeAsNumber = 1;
//                    break;
//            }

//            int PoindC = powerAsNumber * typeAsNumber;
//            return PoindC;
//        }
//    }
//}

//////////using System;
//////////using System.Collections.Generic;
//////////using System.Linq;
//////////using System.Text.RegularExpressions;

//////////namespace SerbianUnleashed
//////////{
//////////    class SerbianUnleashed
//////////    {
//////////        static void Main(string[] args)
//////////        {
//////////            Dictionary<string, Dictionary<string, int>> venuesSingersAndMoney = new Dictionary<string, Dictionary<string, int>>();

//////////            string command = Console.ReadLine();

//////////            while (command != "End")
//////////            {
//////////                DateProceso(command, venuesSingersAndMoney);
//////////                command = Console.ReadLine();
//////////            }
//////////            PrintingResul(venuesSingersAndMoney);
//////////        }

//////////        private static void PrintingResul(Dictionary<string, Dictionary<string, int>> venuesSingersAndMoney)
//////////        {
//////////            foreach (var venues in venuesSingersAndMoney)
//////////            {
//////////                Console.WriteLine(venues.Key);
//////////                foreach (var singer in venues.Value.OrderByDescending(x => x.Value))
//////////                {
//////////                    Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
//////////                }
//////////            }
//////////        }

//////////        private static void DateProceso(string command, Dictionary<string, Dictionary<string, int>> venuesSingersAndMoney)
//////////        {
//////////            string pattern = @"([a-zA-Z]+\s){1,3}@([a-zA-Z0-9]+\s){1,3}[0-9]+\s[0-9]+";
//////////            Regex regex = new Regex(pattern);
//////////            bool hasMatch = regex.IsMatch(command);
//////////            if (!hasMatch)
//////////            {
//////////                return;
//////////            }

//////////            Match matchData = Regex.Match(command, pattern);

//////////            string lineInfo = matchData.Value;
//////////            List<string> data = lineInfo.Split('@').ToList();

//////////            string singer = data[0].Trim();
//////////            string venue = Regex.Match(data[1], @"([a-zA-z]+\s){1,3}").Value.Trim();
//////////            MatchCollection priceAndcount = Regex.Matches(data[1], @"[0-9]+");
//////////            int ticketRevenue = int.Parse(priceAndcount[0].Value) * int.Parse(priceAndcount[1].Value);

//////////            StoreData(venue, singer, ticketRevenue, venuesSingersAndMoney);
//////////        }

//////////        private static void StoreData(string venue, string singer, int ticketRevenue, Dictionary<string, Dictionary<string, int>> venuesSingersAndMoney)
//////////        {
//////////            if (venuesSingersAndMoney.ContainsKey(venue))
//////////            {
//////////                if (venuesSingersAndMoney[venue].ContainsKey(singer))
//////////                {
//////////                    venuesSingersAndMoney[venue][singer] += ticketRevenue;
//////////                }
//////////                else
//////////                {
//////////                    venuesSingersAndMoney[venue].Add(singer, ticketRevenue);
//////////                }
//////////            }
//////////            else
//////////            {
//////////                venuesSingersAndMoney.Add(venue, new Dictionary<string, int> { { singer, ticketRevenue } });
//////////            }
//////////        }
//////////    }
//////////}

//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace LogsAggregator
//{
//    class LogsAggregator
//    {
//        static void Main(string[] args)
//        {
//            Dictionary<string, Dictionary<string, int>> logs = new Dictionary<string, Dictionary<string, int>>();

//            int n = int.Parse(Console.ReadLine());

//            for (int i = 0; i < n; i++)
//            {
//                string commandLine = Console.ReadLine();

//                ProcesingData(commandLine, logs);
//            }
//            SortingData(logs);
//        }

//        private static void SortingData(Dictionary<string, Dictionary<string, int>> logs)
//        {
//            foreach (var user in logs.OrderBy(x => x.Key))
//            {
//                Console.Write($"{user.Key}: {user.Value.Values.Sum()} [");
//                int commaCounter = 0;
//                foreach (var data in user.Value.OrderBy(x => x.Key))
//                {
//                    Console.Write($"{data.Key}");
//                    if (commaCounter < user.Value.Count - 1)
//                    {
//                        Console.Write(", ");
//                        commaCounter++;
//                    }
//                    else
//                    {
//                        Console.WriteLine("]");
//                    }
//                }
//            }
//        }

//        private static void ProcesingData(string commandLine, Dictionary<string, Dictionary<string, int>> logs)
//        {
//            List<string> data = commandLine.Split().ToList();
//            string iP = data[0];
//            string userID = data[1];
//            int time = int.Parse(data[2]);

//            if (logs.ContainsKey(userID))
//            {
//                if (logs[userID].ContainsKey(iP))
//                {
//                    logs[userID][iP] += time;
//                }
//                else
//                {
//                    logs[userID].Add(iP, time);
//                }
//            }
//            else
//            {
//                logs.Add(userID, new Dictionary<string, int> { { iP, time } });
//            }
//        }
//    }
//}


using System;
using System.Collections.Generic;
using System.Linq;

namespace PopulationCounter
{
    class PopulationCounter
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> countries = new Dictionary<string, Dictionary<string, long>>();

            string command = Console.ReadLine();
            while (command != "report")
            {
                TreatRawData(countries, command);
                command = Console.ReadLine();
            }
            PrintReport(countries);
            Console.WriteLine();
        }

        private static void PrintReport(Dictionary<string, Dictionary<string, long>> countries)
        {
            foreach (var c in countries.OrderByDescending(x => x.Value.Values.Sum()))
            {
                string name = c.Key.ToString();
                Console.WriteLine($"{c.Key} (total population: {c.Value.Values.Sum()})");
                foreach (var city in c.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }

        private static void TreatRawData(Dictionary<string, Dictionary<string, long>> countries, string command)
        {
            List<string> lineInput = command.Split('|').ToList();
            string city = lineInput[0];
            string country = lineInput[1];
            long popu = long.Parse(lineInput[2]);

            if (countries.ContainsKey(country))
            {
                if (countries[country].ContainsKey(city))
                {
                    countries[country][city] += popu;
                }
                else
                {
                    countries[country].Add(city, popu);
                }
            }
            else
            {
                countries.Add(country, new Dictionary<string, long> { { city, popu } });
            }
        }
    }
}
