	//==========================================================
	// Student Number	: S10267822
	// Student Name	: Lau Jia Qi
	// Partner Name	: Ee Ting Li
//==========================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PRG2_Assignment
{
    class BoardingGate
    {
        //Properties
        public string gateName { get; set; }
        public bool supportsCFFT { get; set; }
        public bool supportsDDJB { get; set; }
        public bool supportsLWTT { get; set; }
        public Flight Flight { get; set; }

        //Default Constructor
        public BoardingGate() { }

        //Parameterized Constructor
        public BoardingGate(string GateName, bool SupportsCFFT, bool SupportsDDJB, bool SupportsLWTT)
        {
            gateName = GateName;
            supportsCFFT = SupportsCFFT;
            supportsDDJB = SupportsDDJB;
            supportsLWTT = SupportsLWTT;
        }

        //Methods
        //Calculate Fees
        public double CalculateFees()
        {
            double baseFee = 300.0;
            if (Flight != null)
            {
                return baseFee + Flight.CalculateFees(); ;
            }
            return baseFee;
        }

        //TOString() method
        public override string ToString()
        {
            return $"Gate Name: {gateName}\nSupports CFFT: {supportsCFFT}\nSupports DDJB: {supportsDDJB}\nSupports LWTT: {supportsLWTT}\nFlight: {Flight}";
        }
    }
}

