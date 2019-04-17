using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Speech.Synthesis;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SpeechSynthesizer s = new SpeechSynthesizer();

                using (SpeechSynthesizer synthesizer = new SpeechSynthesizer())
                {
                    synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Teen);
                    PromptBuilder builder = new PromptBuilder();
                    builder.AppendText("WELCOME  TO  CAR  GAME PLEASE FOLLOW STEPS CAREFULLY");
                    synthesizer.Speak(builder);
                }


                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n");
                Console.WriteLine("\n");
                using (SpeechSynthesizer synthesizer = new SpeechSynthesizer())
                {
                    synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Senior);
                    PromptBuilder builder = new PromptBuilder();
                    builder.AppendText("ENTER YOUR FIRST NAME");
                    synthesizer.Speak(builder);
                }
                Console.Write("ENTER YOUR FIRST NAME :");
                string nam = Console.ReadLine();
                using (SpeechSynthesizer synthesizer = new SpeechSynthesizer())
                {
                    synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Senior);
                    PromptBuilder builder = new PromptBuilder();
                    builder.AppendText("ENTER YOUR LAST NAME");
                    synthesizer.Speak(builder);
                }
                Console.Write("ENTER YOUR LAST NAME :");
                string nam1 = Console.ReadLine();

                using (SpeechSynthesizer synthesizer = new SpeechSynthesizer())
                {
                    synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Teen);
                    PromptBuilder builder = new PromptBuilder();
                    builder.AppendText("PRESS 1 TO PLAY GAME OR PRESS 2 FOR VIEW YOUR PREVIOUS SCORE");
                    synthesizer.Speak(builder);
                }

                Console.WriteLine("PRESS 1 TO PLAY GAME OR PRESS 2 FOR VIEW YOUR PREVIOUS SCORE");
                string hold = Console.ReadLine();

                Console.Clear();

                if (hold == "2")
                {
                    string readText = File.ReadAllText("" + nam + nam1 + ".txt");
                    Console.WriteLine("\n\n\n\n");
                    Console.Write(nam + " " + nam1);
                    Console.Write("  Your previous score was   " + readText);
                    using (SpeechSynthesizer synthesizer = new SpeechSynthesizer())
                    {
                        synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Teen);
                        PromptBuilder builder = new PromptBuilder();
                        builder.AppendText(nam+" "+nam1+"  Your previous score was   " + readText);
                        synthesizer.Speak(builder);
                    }
                    
                    Console.WriteLine("\n\n\n\n");
                }
                else
                {

                    Console.WriteLine("\n");
                    Console.WriteLine("\n");
                    Console.WriteLine("                                  CAR GAME            ");
                    Console.WriteLine();
                    Console.WriteLine("                              =========");
                    Console.WriteLine("                             =    |   =");
                    Console.WriteLine("                            =     |    =");
                    Console.WriteLine("                            ==============");
                    Console.WriteLine("                        =======================");
                    Console.WriteLine("                        =       FERRARI       =");
                    Console.WriteLine("                        =                     =");
                    Console.WriteLine("                        =======================");
                    Console.WriteLine("                           00             00  ");
                    Console.WriteLine("\n");
                    Console.WriteLine("                   Try to save your car from another cars on road");
                    Console.Write("                       Previous  score   is    =   ");
                    string readText = File.ReadAllText("score.txt");
                    Console.Write(readText);
                    Console.WriteLine("\n");
                    Console.WriteLine("\n");
                    Console.WriteLine("                                    Controls                     ");
                    Console.WriteLine("                              press enter for drive ");
                    Console.WriteLine("                              press R for Right move");
                    Console.WriteLine("                              press L for left move");
                    Console.WriteLine("\n");
                    Console.WriteLine("                            Enjoy...................");
                    Console.WriteLine("\n");
                    using (SpeechSynthesizer synthesizer = new SpeechSynthesizer())
                    {
                        synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Teen);
                        PromptBuilder builder = new PromptBuilder();
                        builder.AppendText("PRESS ANY KEY TO CONTINUE");
                        synthesizer.Speak(builder);
                    }
                    Console.WriteLine("                             press any key to continue");
                    Console.ReadLine();
                    Console.Clear();
                    int score = 0;
                    int life = 13;
                    for (int i = 1; i < 12; i++)
                    {
                        life--;
                        Console.ForegroundColor = ConsoleColor.Green;
                        using (SpeechSynthesizer synthesizer = new SpeechSynthesizer())
                        {
                            synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Senior);
                            PromptBuilder builder = new PromptBuilder();
                            builder.AppendText("                  your score is  " + score);
                            synthesizer.Speak(builder);
                        }
                        Console.WriteLine("                  your score is  " + score);
                        Console.WriteLine("                     game life left  " + life);
                        using (SpeechSynthesizer synthesizer = new SpeechSynthesizer())
                        {
                            synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Teen);
                            PromptBuilder builder = new PromptBuilder();
                            builder.AppendText("             press enter to continue Or press e for exit");
                            synthesizer.Speak(builder);
                        }
                        Console.WriteLine("             press enter to continue.....................");
                        Console.WriteLine("             Or press e for exit");
                        string check = Console.ReadLine();
                        if (check == "e")
                        {
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("                     |               |                |               |       ");
                            Console.WriteLine("                     |               |      =         |               |       ");
                            Console.WriteLine("                     |               |      =         |               |       ");
                            Console.WriteLine("                     |               |      =         |               |       ");
                            Console.WriteLine("                     |               |      =         |               |       ");
                            Console.WriteLine("                     |               |      =         |      =        |       ");
                            Console.WriteLine("                     |               |                |      =        |       ");
                            Console.WriteLine("                     |               |                |      =        |       ");
                            Console.WriteLine("                     |               |                |      =        |       ");
                            Console.WriteLine("                     |               |                |      =        |       ");
                            Console.WriteLine("                     |               |                |               |       ");
                            Console.WriteLine("                     |               |                |               |       ");
                            Console.WriteLine("                     |               |                |               |       ");
                            Console.WriteLine("                     |      =        |                |               |       ");
                            Console.WriteLine("                     |      =        |                |               |       ");
                            Console.WriteLine("                     |      =        |                |               |       ");
                            Console.WriteLine("                     |      =        |                |               |       ");
                            Console.WriteLine("                     |      =        |                |               |       ");
                            Console.WriteLine("                     |               |                |               |       ");
                            Console.WriteLine("                     |               |                |               |       ");
                            Console.WriteLine("                     |               |                |      =        |       ");
                            Console.WriteLine("                     |               |                |      =        |       ");
                            Console.WriteLine("                     |               |       =        |      =        |       ");
                            Console.WriteLine("                     |               |       =        |      =        |       ");
                            Console.WriteLine("                     |               |       =        |      =        |       ");
                            Console.WriteLine("                     |               |       =        |               |       ");
                            Console.WriteLine("                     |               |       =        |               |       ");
                            Console.WriteLine("                     |               |                |               |       ");
                            Console.WriteLine("                     |               |                |               |       ");
                            Console.WriteLine("                     |      =        |                |               |       ");
                            Console.WriteLine("                     |      =        |                |               |       ");
                            Console.WriteLine("                     |      =        |                |               |       ");
                            Console.WriteLine("                     |      =        |       @        |               |       ");
                            Console.WriteLine("                     |      =        | ___ @@@@@____  |               |       ");
                            Console.WriteLine("                     |               |o|@@@@@@@@@@@@|o|               |       ");
                            Console.WriteLine("                     |               | |@@@@@@@@@@@@| |               |       ");
                            Console.WriteLine("                     |               | |@@@@@@@@@@@@| |               |       ");
                            Console.WriteLine("                     |               | |@@@@@@@@@@@@| |               |       ");
                            Console.WriteLine("                     |               | |@@@@@@@@@@@@| |               |       ");
                            Console.WriteLine("                     |               | |@@@@@@@@@@@@| |               |       ");
                            Console.WriteLine("                     |               |O|@@@@@@@@@@@@|O|               |       ");
                            Console.WriteLine("                     |               | |@@@@@@@@@@@@| |               |       ");

                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("                     |               |                |               |       ");
                            Console.WriteLine("                     |               |                |               |       ");
                            Console.WriteLine("                     |               |    NO WAY      |               |       ");
                            Console.WriteLine("                     |               |================|               |       ");
                            Console.WriteLine("                     |               |================|               |       ");
                            Console.WriteLine("                     |               |      =         |               |       ");
                            Console.WriteLine("                     |    NO WAY     |      =         |               |       ");
                            Console.WriteLine("                     |===============|      =         |               |       ");
                            Console.WriteLine("                     |===============|      =         |               |       ");
                            Console.WriteLine("                     |               |      =         |               |       ");
                            Console.WriteLine("                     |               |                |               |       ");
                            Console.WriteLine("                     |               |                |               |       ");
                            Console.WriteLine("                     |               |                |               |       ");
                            Console.WriteLine("                     |               |                |               |       ");
                            Console.WriteLine("                     |               |                |               |       ");
                            Console.WriteLine("                     |               |                |               |       ");
                            Console.WriteLine("                     |               |                |               |       ");
                            Console.WriteLine("                     |               |                |               |       ");
                            Console.WriteLine("                     |               |                |      =        |       ");
                            Console.WriteLine("                     |               |                |      =        |       ");
                            Console.WriteLine("                     |               |                |      =        |       ");
                            Console.WriteLine("                     |               |                |      =        |       ");
                            Console.WriteLine("                     |               |                |      =        |       ");
                            Console.WriteLine("                     |      =        |                |               |       ");
                            Console.WriteLine("                     |      =        |                |               |       ");
                            Console.WriteLine("                     |      =        |                |               |       ");
                            Console.WriteLine("                     |      =        |                |               |       ");
                            Console.WriteLine("                     |      =        |                |               |       ");
                            Console.WriteLine("                     |               |                |               |       ");
                            Console.WriteLine("                     |               |                |               |       ");
                            Console.WriteLine("                     |               |                |               |       ");
                            Console.WriteLine("                     |               |                |               |       ");
                            Console.WriteLine("                     |               |       @        |               |       ");
                            Console.WriteLine("                     |               | ___ @@@@@____  |               |       ");
                            Console.WriteLine("                     |               |o|@@@@@@@@@@@@|o|               |       ");
                            Console.WriteLine("                     |               | |@@@@@@@@@@@@| |               |       ");
                            Console.WriteLine("                     |               | |@@@@@@@@@@@@| |               |       ");
                            Console.WriteLine("                     |               | |@@@@@@@@@@@@| |               |       ");
                            Console.WriteLine("                     |               | |@@@@@@@@@@@@| |               |       ");
                            Console.WriteLine("                     |               | |@@@@@@@@@@@@| |               |       ");
                            Console.WriteLine("                     |               |O|@@@@@@@@@@@@|O|               |       ");
                            Console.WriteLine("                     |               | |@@@@@@@@@@@@| |               |       ");
                            Console.ReadLine();
                            Console.Clear();

                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("                     |               |                |               |       ");
                            Console.WriteLine("                     |               |      =         |               |       ");
                            Console.WriteLine("                     |               |      =         |               |       ");
                            Console.WriteLine("                     |               |      =         |               |       ");
                            Console.WriteLine("                     |               |      =         |               |       ");
                            Console.WriteLine("                     |               |      =         |      =        |       ");
                            Console.WriteLine("                     |               |                |      =        |       ");
                            Console.WriteLine("                     |               |                |      =        |       ");
                            Console.WriteLine("                     |               |                |      =        |       ");
                            Console.WriteLine("                     |               |                |      =        |       ");
                            Console.WriteLine("                     |               |                |               |       ");
                            Console.WriteLine("                     |               |                |               |       ");
                            Console.WriteLine("                     |               |                |               |       ");
                            Console.WriteLine("                     |      =        |                |               |       ");
                            Console.WriteLine("                     |      =        |                |               |       ");
                            Console.WriteLine("                     |      =        |                |               |       ");
                            Console.WriteLine("                     |      =        |                |               |       ");
                            Console.WriteLine("                     |      =        |                |               |       ");
                            Console.WriteLine("                     |               |                |               |       ");
                            Console.WriteLine("                     |               |                |               |       ");
                            Console.WriteLine("                     |               |                |      =        |       ");
                            Console.WriteLine("                     |               |                |      =        |       ");
                            Console.WriteLine("                     |               |                |      =        |       ");
                            Console.WriteLine("                     |               |    NO WAY      |      =        |       ");
                            Console.WriteLine("                     |               |================|      =        |       ");
                            Console.WriteLine("                     |               |================|               |       ");
                            Console.WriteLine("                     |    NO WAY     |                |               |       ");
                            Console.WriteLine("                     |===============|                |               |       ");
                            Console.WriteLine("                     |===============|                |               |       ");
                            Console.WriteLine("                     |      =        |                |               |       ");
                            Console.WriteLine("                     |      =        |                |               |       ");
                            Console.WriteLine("                     |      =        |                |               |       ");
                            Console.WriteLine("                     |      =        |       @        |               |       ");
                            Console.WriteLine("                     |      =        | ___ @@@@@____  |               |       ");
                            Console.WriteLine("                     |               |o|@@@@@@@@@@@@|o|               |       ");
                            Console.WriteLine("                     |               | |@@@@@@@@@@@@| |               |       ");
                            Console.WriteLine("                     |               | |@@@@@@@@@@@@| |               |       ");
                            Console.WriteLine("                     |               | |@@@@@@@@@@@@| |               |       ");
                            Console.WriteLine("                     |               | |@@@@@@@@@@@@| |               |       ");
                            Console.WriteLine("                     |               | |@@@@@@@@@@@@| |               |       ");
                            Console.WriteLine("                     |               |O|@@@@@@@@@@@@|O|               |       ");
                            Console.WriteLine("                     |               | |@@@@@@@@@@@@| |               |       ");


                            string turn = Console.ReadLine();
                            Console.Clear();


                            if (turn == "r")
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                score += 10;
                                Console.WriteLine("                     |               |                |                |       ");
                                Console.WriteLine("                     |               |      =         |                |       ");
                                Console.WriteLine("                     |               |      =         |                |       ");
                                Console.WriteLine("                     |               |      =         |                |       ");
                                Console.WriteLine("                     |               |      =         |                |       ");
                                Console.WriteLine("                     |               |      =         |       =        |       ");
                                Console.WriteLine("                     |               |                |       =        |       ");
                                Console.WriteLine("                     |               |                |       =        |       ");
                                Console.WriteLine("                     |               |                |       =        |       ");
                                Console.WriteLine("                     |               |                |       =        |       ");
                                Console.WriteLine("                     |               |                |                |       ");
                                Console.WriteLine("                     |               |                |                |       ");
                                Console.WriteLine("                     |               |                |                |       ");
                                Console.WriteLine("                     |      =        |                |                |       ");
                                Console.WriteLine("                     |      =        |                |                |       ");
                                Console.WriteLine("                     |      =        |                |                |       ");
                                Console.WriteLine("                     |      =        |                |                |       ");
                                Console.WriteLine("                     |      =        |                |                |       ");
                                Console.WriteLine("                     |               |                |                |       ");
                                Console.WriteLine("                     |               |                |                |       ");
                                Console.WriteLine("                     |               |                |       =        |       ");
                                Console.WriteLine("                     |               |                |       =        |       ");
                                Console.WriteLine("                     |               |       =        |       =        |       ");
                                Console.WriteLine("                     |               |       =        |       =        |       ");
                                Console.WriteLine("                     |               |       =        |       =        |       ");
                                Console.WriteLine("                     |               |       =        |                |       ");
                                Console.WriteLine("                     |               |       =        |                |       ");
                                Console.WriteLine("                     |               |                |                |       ");
                                Console.WriteLine("                     |               |                |                |       ");
                                Console.WriteLine("                     |      =        |                |                |       ");
                                Console.WriteLine("                     |      =        |                |       @        |       ");
                                Console.WriteLine("                     |      =        |                | ___ @@@@@____  |       ");
                                Console.WriteLine("                     |      =        |                |o|@@@@@@@@@@@@|o|       ");
                                Console.WriteLine("                     |      =        |                | |@@@@@@@@@@@@| |       ");
                                Console.WriteLine("                     |               |                | |@@@@@@@@@@@@| |       ");
                                Console.WriteLine("                     |               |                | |@@@@@@@@@@@@| |       ");
                                Console.WriteLine("                     |               |                | |@@@@@@@@@@@@| |       ");
                                Console.WriteLine("                     |               |                | |@@@@@@@@@@@@| |       ");
                                Console.WriteLine("                     |               |                |O|@@@@@@@@@@@@|O|       ");
                                Console.WriteLine("                     |               |    NO WAY      | |@@@@@@@@@@@@| |       ");
                                Console.WriteLine("                     |               |=============== |                |       ");
                                Console.WriteLine("                     |               |=============== |                |       ");


                                Console.ReadLine();
                                Console.Clear();

                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("                     |               |                |    NO WAY      |       ");
                                Console.WriteLine("                     |               |      =         |================|       ");
                                Console.WriteLine("                     |               |      =         |================|       ");
                                Console.WriteLine("                     |               |      =         |                |       ");
                                Console.WriteLine("                     |               |      =         |                |       ");
                                Console.WriteLine("                     |               |      =         |       =        |       ");
                                Console.WriteLine("                     |               |                |       =        |       ");
                                Console.WriteLine("                     |               |                |       =        |       ");
                                Console.WriteLine("                     |               |                |       =        |       ");
                                Console.WriteLine("                     |               |                |       =        |       ");
                                Console.WriteLine("                     |               |                |                |       ");
                                Console.WriteLine("                     |               |                |                |       ");
                                Console.WriteLine("                     |               |                |                |       ");
                                Console.WriteLine("                     |      =        |                |                |       ");
                                Console.WriteLine("                     |      =        |                |                |       ");
                                Console.WriteLine("                     |      =        |                |                |       ");
                                Console.WriteLine("                     |      =        |                |                |       ");
                                Console.WriteLine("                     |      =        |                |                |       ");
                                Console.WriteLine("                     |               |                |                |       ");
                                Console.WriteLine("                     |               |                |                |       ");
                                Console.WriteLine("                     |               |                |       =        |       ");
                                Console.WriteLine("                     |               |                |       =        |       ");
                                Console.WriteLine("                     |               |       =        |       =        |       ");
                                Console.WriteLine("                     |               |       =        |       =        |       ");
                                Console.WriteLine("                     |    NO WAY     |       =        |       =        |       ");
                                Console.WriteLine("                     |===============|       =        |                |       ");
                                Console.WriteLine("                     |===============|       =        |                |       ");
                                Console.WriteLine("                     |               |                |                |       ");
                                Console.WriteLine("                     |               |                |                |       ");
                                Console.WriteLine("                     |      =        |                |                |       ");
                                Console.WriteLine("                     |      =        |                |       @        |       ");
                                Console.WriteLine("                     |      =        |                | ___ @@@@@____  |       ");
                                Console.WriteLine("                     |      =        |                |o|@@@@@@@@@@@@|o|       ");
                                Console.WriteLine("                     |      =        |                | |@@@@@@@@@@@@| |       ");
                                Console.WriteLine("                     |               |                | |@@@@@@@@@@@@| |       ");
                                Console.WriteLine("                     |               |                | |@@@@@@@@@@@@| |       ");
                                Console.WriteLine("                     |               |                | |@@@@@@@@@@@@| |       ");
                                Console.WriteLine("                     |               |                | |@@@@@@@@@@@@| |       ");
                                Console.WriteLine("                     |               |                |O|@@@@@@@@@@@@|O|       ");
                                Console.WriteLine("                     |               |    NO WAY      | |@@@@@@@@@@@@| |       ");
                                Console.WriteLine("                     |               |=============== |                |       ");
                                Console.WriteLine("                     |               |=============== |                |       ");
                                Console.ReadLine();
                                Console.Clear();

                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("                     |               |                |                |       ");
                                Console.WriteLine("                     |               |      =         |                |       ");
                                Console.WriteLine("                     |               |      =         |                |       ");
                                Console.WriteLine("                     |               |      =         |                |       ");
                                Console.WriteLine("                     |               |      =         |                |       ");
                                Console.WriteLine("                     |               |      =         |       =        |       ");
                                Console.WriteLine("                     |               |                |       =        |       ");
                                Console.WriteLine("                     |               |                |       =        |       ");
                                Console.WriteLine("                     |               |                |       =        |       ");
                                Console.WriteLine("                     |               |                |       =        |       ");
                                Console.WriteLine("                     |               |                |                |       ");
                                Console.WriteLine("                     |               |                |                |       ");
                                Console.WriteLine("                     |               |                |                |       ");
                                Console.WriteLine("                     |      =        |                |                |       ");
                                Console.WriteLine("                     |      =        |                |                |       ");
                                Console.WriteLine("                     |      =        |                |                |       ");
                                Console.WriteLine("                     |      =        |                |                |       ");
                                Console.WriteLine("                     |      =        |                |                |       ");
                                Console.WriteLine("                     |               |                |                |       ");
                                Console.WriteLine("                     |               |                |                |       ");
                                Console.WriteLine("                     |               |                |       =        |       ");
                                Console.WriteLine("                     |               |                |       =        |       ");
                                Console.WriteLine("                     |               |       =        |       =        |       ");
                                Console.WriteLine("                     |               |       =        |       =        |       ");
                                Console.WriteLine("                     |               |       =        |       =        |       ");
                                Console.WriteLine("                     |               |       =        |     NO WAY     |       ");
                                Console.WriteLine("                     |               |       =        |================|       ");
                                Console.WriteLine("                     |               |                |================|       ");
                                Console.WriteLine("                     |               |                |                |       ");
                                Console.WriteLine("                     |      =        |                |                |       ");
                                Console.WriteLine("                     |      =        |                |       @        |       ");
                                Console.WriteLine("                     |      =        |                | ___ @@@@@____  |       ");
                                Console.WriteLine("                     |      =        |                |o|@@@@@@@@@@@@|o|       ");
                                Console.WriteLine("                     |      =        |                | |@@@@@@@@@@@@| |       ");
                                Console.WriteLine("                     |               |                | |@@@@@@@@@@@@| |       ");
                                Console.WriteLine("                     |               |                | |@@@@@@@@@@@@| |       ");
                                Console.WriteLine("                     |               |                | |@@@@@@@@@@@@| |       ");
                                Console.WriteLine("                     |               |                | |@@@@@@@@@@@@| |       ");
                                Console.WriteLine("                     |               |                |O|@@@@@@@@@@@@|O|       ");
                                Console.WriteLine("                     |               |                | |@@@@@@@@@@@@| |       ");
                                Console.WriteLine("                     |               |                |                |       ");
                                Console.WriteLine("                     |               |                |                |       ");

                                string turn1 = Console.ReadLine();
                                Console.Clear();
                                if (turn1 == "l")
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    score += 300;
                                    Console.WriteLine("                     |               |                |               |       ");
                                    Console.WriteLine("                     |               |      =         |               |       ");
                                    Console.WriteLine("                     |               |      =         |               |       ");
                                    Console.WriteLine("                     |               |      =         |               |       ");
                                    Console.WriteLine("                     |               |      =         |               |       ");
                                    Console.WriteLine("                     |               |      =         |      =        |       ");
                                    Console.WriteLine("                     |               |                |      =        |       ");
                                    Console.WriteLine("                     |               |                |      =        |       ");
                                    Console.WriteLine("                     |               |                |      =        |       ");
                                    Console.WriteLine("                     |               |                |      =        |       ");
                                    Console.WriteLine("                     |               |                |               |       ");
                                    Console.WriteLine("                     |               |                |               |       ");
                                    Console.WriteLine("                     |               |                |               |       ");
                                    Console.WriteLine("                     |      =        |                |               |       ");
                                    Console.WriteLine("                     |      =        |                |               |       ");
                                    Console.WriteLine("                     |      =        |                |               |       ");
                                    Console.WriteLine("                     |      =        |                |               |       ");
                                    Console.WriteLine("                     |      =        |                |               |       ");
                                    Console.WriteLine("                     |               |                |               |       ");
                                    Console.WriteLine("                     |               |                |               |       ");
                                    Console.WriteLine("                     |               |                |      =        |       ");
                                    Console.WriteLine("                     |               |                |      =        |       ");
                                    Console.WriteLine("                     |               |       =        |      =        |       ");
                                    Console.WriteLine("                     |               |       =        |      =        |       ");
                                    Console.WriteLine("                     |               |       =        |      =        |       ");
                                    Console.WriteLine("                     |               |       =        |               |       ");
                                    Console.WriteLine("                     |               |       =        |               |       ");
                                    Console.WriteLine("                     |      =        |                |               |       ");
                                    Console.WriteLine("                     |      =        |                |               |       ");
                                    Console.WriteLine("                     |      =        |                |               |       ");
                                    Console.WriteLine("                     |      =        |       @        |               |       ");
                                    Console.WriteLine("                     |      =        | ___ @@@@@____  |               |       ");
                                    Console.WriteLine("                     |               |o|@@@@@@@@@@@@|o|               |       ");
                                    Console.WriteLine("                     |               | |@@@@@@@@@@@@| |               |       ");
                                    Console.WriteLine("                     |               | |@@@@@@@@@@@@| |               |       ");
                                    Console.WriteLine("                     |               | |@@@@@@@@@@@@| |               |       ");
                                    Console.WriteLine("                     |               | |@@@@@@@@@@@@| |               |       ");
                                    Console.WriteLine("                     |               | |@@@@@@@@@@@@| |               |       ");
                                    Console.WriteLine("                     |               |O|@@@@@@@@@@@@|O|               |       ");
                                    Console.WriteLine("                     |               | |@@@@@@@@@@@@| |    NO WAY     |       ");
                                    Console.WriteLine("                     |               |                |===============|       ");
                                    Console.WriteLine("                     |               |                |===============|       ");
                                    Console.ReadLine();
                                    Console.Clear();

                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("                     |               |                |               |       ");
                                    Console.WriteLine("                     |               |      =         |               |       ");
                                    Console.WriteLine("                     |               |      =         |               |       ");
                                    Console.WriteLine("                     |               |      =         |               |       ");
                                    Console.WriteLine("                     |               |      =         |               |       ");
                                    Console.WriteLine("                     |               |      =         |      =        |       ");
                                    Console.WriteLine("                     |               |                |      =        |       ");
                                    Console.WriteLine("                     |               |                |      =        |       ");
                                    Console.WriteLine("                     |               |                |      =        |       ");
                                    Console.WriteLine("                     |               |                |      =        |       ");
                                    Console.WriteLine("                     |               |                |               |       ");
                                    Console.WriteLine("                     |               |                |               |       ");
                                    Console.WriteLine("                     |               |                |               |       ");
                                    Console.WriteLine("                     |      =        |                |               |       ");
                                    Console.WriteLine("                     |      =        |                |               |       ");
                                    Console.WriteLine("                     |      =        |                |               |       ");
                                    Console.WriteLine("                     |      =        |                |               |       ");
                                    Console.WriteLine("                     |      =        |                |               |       ");
                                    Console.WriteLine("                     |               |                |               |       ");
                                    Console.WriteLine("                     |               |                |               |       ");
                                    Console.WriteLine("                     |               |                |      =        |       ");
                                    Console.WriteLine("                     |               |                |      =        |       ");
                                    Console.WriteLine("                     |               |       =        |      =        |       ");
                                    Console.WriteLine("                     |               |       =        |      =        |       ");
                                    Console.WriteLine("                     |               |       =        |      =        |       ");
                                    Console.WriteLine("                     |               |       =        |               |       ");
                                    Console.WriteLine("                     |               |       =        |               |       ");
                                    Console.WriteLine("                     |               |                |               |       ");
                                    Console.WriteLine("                     |               |                |               |       ");
                                    Console.WriteLine("                     |      =        |                |               |       ");
                                    Console.WriteLine("                     |      =        |                |               |       ");
                                    Console.WriteLine("                     |      =        |                |               |       ");
                                    Console.WriteLine("                     |      =        |       @        |               |       ");
                                    Console.WriteLine("                     |      =        | ___ @@@@@____  |               |       ");
                                    Console.WriteLine("                     |               |o|@@@@@@@@@@@@|o|               |       ");
                                    Console.WriteLine("                     |               | |@@@@@@@@@@@@| |               |       ");
                                    Console.WriteLine("                     |               | |@@@@@@@@@@@@| |               |       ");
                                    Console.WriteLine("                     |               | |@@@@@@@@@@@@| |               |       ");
                                    Console.WriteLine("                     |               | |@@@@@@@@@@@@| |               |       ");
                                    Console.WriteLine("                     |               | |@@@@@@@@@@@@| |               |       ");
                                    Console.WriteLine("                     |               |O|@@@@@@@@@@@@|O|               |       ");
                                    Console.WriteLine("                     |               | |@@@@@@@@@@@@| |               |       ");
                                    Console.ReadLine();
                                    Console.Clear();
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("                     |               |                |                 |       ");
                                    Console.WriteLine("                     |               |      =         |                 |       ");
                                    Console.WriteLine("                     |               |      =         |                 |       ");
                                    Console.WriteLine("                     |               |      =         |                 |       ");
                                    Console.WriteLine("                     |               |      =         |                 |       ");
                                    Console.WriteLine("                     |               |      =         |        =        |       ");
                                    Console.WriteLine("                     |               |                |        =        |       ");
                                    Console.WriteLine("                     |               |                |        =        |       ");
                                    Console.WriteLine("                     |               |                |        =        |       ");
                                    Console.WriteLine("                     |               |                |        =        |       ");
                                    Console.WriteLine("                     |               |                |                 |       ");
                                    Console.WriteLine("                     |               |                |                 |       ");
                                    Console.WriteLine("                     |               |                |                 |       ");
                                    Console.WriteLine("                     |      =        |                |                 |       ");
                                    Console.WriteLine("                     |      =        |                |                 |       ");
                                    Console.WriteLine("                     |      =        |                |                 |       ");
                                    Console.WriteLine("                     |      =        |                |                 |       ");
                                    Console.WriteLine("                     |      =        |                |                 |       ");
                                    Console.WriteLine("                     |               |                |                 |       ");
                                    Console.WriteLine("                     |               |                |                 |       ");
                                    Console.WriteLine("                     |               |                |        =        |       ");
                                    Console.WriteLine("                     |               |                |        =        |       ");
                                    Console.WriteLine("                     |               |       =        |        =        |       ");
                                    Console.WriteLine("                     |               |       =        |        =        |       ");
                                    Console.WriteLine("                     |               |       =        |        =        |       ");
                                    Console.WriteLine("                     |               |       =        |                 |       ");
                                    Console.WriteLine("                     |               |       =        |                 |       ");
                                    Console.WriteLine("                     |               |                |                 |       ");
                                    Console.WriteLine("                     |               |                |      NO WAY     |       ");
                                    Console.WriteLine("                     |      =        |                |================ |       ");
                                    Console.WriteLine("                     |      =        |                |================ |       ");
                                    Console.WriteLine("                     |      =        |                | ___ @@@@@____/ /|       ");
                                    Console.WriteLine("                     |      =        |                |o|@@@@@@@@@@@@|o |       ");
                                    Console.WriteLine("                     |      =        |                | |@@@@@@@@@@@@|  |       ");
                                    Console.WriteLine("                     |               |                | |@@@@@@@@@@@@|  |       ");
                                    Console.WriteLine("                     |               |                | |@@@@@@@@@@@@|  |       ");
                                    Console.WriteLine("                     |               |                | |@@@@@@@@@@@@|  |       ");
                                    Console.WriteLine("                     |               |                | |@@@@@@@@@@@@|  |       ");
                                    Console.WriteLine("                     |               |                |O|@@@@@@@@@@@@|O |       ");
                                    Console.WriteLine("                     |               |                | |@@@@@@@@@@@@|  |       ");
                                    Console.WriteLine("                     |               |                |              \\ |       ");
                                    Console.WriteLine("                     |               |                |               \\|       ");
                                    Console.WriteLine("\n");
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("           Opp's cars are destroyed you lost         ");
                                    using (SpeechSynthesizer synthesizer = new SpeechSynthesizer())
                                    {
                                        synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Teen);
                                        PromptBuilder builder = new PromptBuilder();
                                        builder.AppendText("opp's car are destroyed . good luck try again");
                                        synthesizer.Speak(builder);
                                    }

                                }




                            }
                            else
                            {

                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("                     |               |                 |               |       ");
                                Console.WriteLine("                     |               |       =         |               |       ");
                                Console.WriteLine("                     |               |       =         |               |       ");
                                Console.WriteLine("                     |               |       =         |               |       ");
                                Console.WriteLine("                     |               |       =         |               |       ");
                                Console.WriteLine("                     |               |       =         |      =        |       ");
                                Console.WriteLine("                     |               |                 |      =        |       ");
                                Console.WriteLine("                     |               |                 |      =        |       ");
                                Console.WriteLine("                     |               |                 |      =        |       ");
                                Console.WriteLine("                     |      =        |                 |      =        |       ");
                                Console.WriteLine("                     |      =        |                 |               |       ");
                                Console.WriteLine("                     |      =        |                 |               |       ");
                                Console.WriteLine("                     |      =        |                 |               |       ");
                                Console.WriteLine("                     |      =        |                 |               |       ");
                                Console.WriteLine("                     |               |                 |      =        |       ");
                                Console.WriteLine("                     |               |                 |      =        |       ");
                                Console.WriteLine("                     |               |        =        |      =        |       ");
                                Console.WriteLine("                     |               |        =        |      =        |       ");
                                Console.WriteLine("                     |               |        =        |      =        |       ");
                                Console.WriteLine("                     |               |        =        |               |       ");
                                Console.WriteLine("                     |               |        =        |               |       ");
                                Console.WriteLine("                     |               |                 |               |       ");
                                Console.WriteLine("                     |               |                 |               |       ");
                                Console.WriteLine("                     |      =        |                 |               |       ");
                                Console.WriteLine("                     |      =        |      NO WAY     |               |       ");
                                Console.WriteLine("                     |      =        |=================|               |       ");
                                Console.WriteLine("                     |      =        |=================|               |       ");
                                Console.WriteLine("                     |      =        |  ___ @@@@@____//|               |       ");
                                Console.WriteLine("                     |               | o|@@@@@@@@@@@@|o|               |       ");
                                Console.WriteLine("                     |               |  |@@@@@@@@@@@@| |               |       ");
                                Console.WriteLine("                     |               |  |@@@@@@@@@@@@| |               |       ");
                                Console.WriteLine("                     |               |  |@@@@@@@@@@@@| |               |       ");
                                Console.WriteLine("                     |               |  |@@@@@@@@@@@@| |               |       ");
                                Console.WriteLine("                     |               |  |@@@@@@@@@@@@| |               |       ");
                                Console.WriteLine("                     |               | O|@@@@@@@@@@@@|O|               |       ");
                                Console.WriteLine("                     |               |  |@@@@@@@@@@@@| |               |       ");
                                Console.WriteLine("                     |               |              \\ |               |       ");
                                Console.WriteLine("                     |               |               \\|               |       ");
                                Console.WriteLine("                     |               |                 |               |       ");
                                Console.WriteLine("                     |               |                 |               |       ");
                                Console.WriteLine("                     |               |                 |               |       ");
                                Console.WriteLine("                     |               |                 |               |       ");
                                Console.WriteLine("\n");
                                
                                Console.WriteLine("           Opp's cars are destroyed you lost         ");
                                using (SpeechSynthesizer synthesizer = new SpeechSynthesizer())
                                {
                                    synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Teen);
                                    PromptBuilder builder = new PromptBuilder();
                                    builder.AppendText("opp's car are destroyed . good luck try again");
                                    synthesizer.Speak(builder);
                                }


                            }
                        }
                    }


                    string sco = Convert.ToString(score);

                    File.WriteAllText("score.txt", sco);
                    File.WriteAllText("" + nam + "" + nam1 + ".txt", sco);


                }
            }
            catch (Exception e)
            {
                Console.WriteLine("You have not any previous record ");
                Console.WriteLine("Open application again");
                Console.WriteLine(e.Message);
            }
            finally
            {
                using (SpeechSynthesizer synthesizer = new SpeechSynthesizer())
                {
                    synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Teen);
                    PromptBuilder builder = new PromptBuilder();
                    builder.AppendText("Thanks For play our game  Copyright all rights reserved CMT software house please visit our website www.easysolutions.gq");
                    Console.WriteLine("Thanks For play our game \n  Copyright all rights reserved CMT software house \n please visit our website www.easysolutions.gq");
                    synthesizer.Speak(builder);
                }
            }


        }

    }
}

