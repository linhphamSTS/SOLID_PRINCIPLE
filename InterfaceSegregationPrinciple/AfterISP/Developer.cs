using System;

namespace InterfaceSegregationPrinciple.AfterISP
{
    internal class Developer : IDevActivity
    {
        public string Name { get; set; }

        public void JoinMeeting()
        {
            Console.WriteLine("I join the meeting...!");
        }

        public void StudyRequirement()
        {
            Console.WriteLine("FUCK, It is a stupid document from BA.");
        }

        public void WriteCode()
        {
            Console.WriteLine("OH YEAH, I AM SUPPER CODER");
        }
    }
}