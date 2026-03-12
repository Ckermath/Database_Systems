using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQL_Form1.dbAccess;
using System.Text.RegularExpressions;

namespace SQL_Form1.GUI
{
    public class WeddingList
    {
        public WeddingList()
        {

        }

        int weddingListNo;
        string clientForename;
        string clientSurname;
        int houseNumber;
        string streetName;
        string townName;
        string postCode;
        string clientContactNo;
        DateTime eventDate;
        DateTime setupDate;
        string employeeName;


        public WeddingList(int weddingListNo, string clientForename, string clientSurname, int houseNumber, string streetName, string townName, string postCode, string clientContactNo, DateTime eventDate, DateTime setupDate, string employeeName)
        {
            this.weddingListNo = weddingListNo;
            this.clientForename = clientForename;
            this.clientSurname = clientSurname;
            this.houseNumber = houseNumber;
            this.streetName = streetName;
            this.townName = townName;
            this.postCode = postCode;
            this.clientContactNo = clientContactNo;
            this.eventDate = eventDate;
            this.setupDate = setupDate;
            this.employeeName = employeeName;
        }
        private bool Checknumber(string number)
        {
            bool valid = true;
            foreach (char c in number)
            {
                if (!char.IsNumber(c))
                {
                    valid = false;
                }
                else
                    valid = true;
            }
            return valid;
        }

        private bool CheckNameLength(string value)
        {
            bool valid = true;
            if (value.Length > 30)
            {
                valid = false;
            }
            return valid;
        }

        private bool CheckStreetNameLength(string value)
        {
            bool valid = true;
            if (value.Length > 70)
            {
                valid = false;
            }
            return valid;
        }
        private bool CheckDate(DateTime value)
        {
            if (setupDate < value)
            {
                return true;
            }
            return false;
        }
        private bool CheckPresent(string value)
        {
            if (String.IsNullOrWhiteSpace(value)) return false;
            else
                return true;
        }
        private bool CheckLength(string value)
        {
            bool valid = true;
            if (value.Length != 11)
            {
                valid = false;
            }
            return valid;
        }

        private bool CheckPostcode(string PostCode)
        {
            bool valid = true;
            if (!Regex.Match(PostCode, "^([Gg][Ii][Rr] 0[Aa]{2}|([A-Za-z][0-9]{1,2}|[A-Za-z][A-Ha-hJ-Yj-y][0-9]{1,2}|[A-Za-z][0-9][A-Za-z]|[A-Za-z][A-Ha-hJ-Yj-y][0-9]?[A-Za-z]) ?[0-9][A-Za-z]{2})$").Success)
                valid = false;
            return valid;
        }
        public int WeddingListNo { get => weddingListNo; set => weddingListNo = value; }
        public string ClientForename
        {
            get { return clientForename; }

            set
            {
                if (CheckPresent(value))
                    clientForename = value;
                else throw new Exception();
            }
        }
        public string ClientSurname
        {
            get { return clientSurname; }

            set
            {
                if (CheckPresent(value))
                    clientSurname = value;
                else throw new Exception();
            }
        }
        public int HouseNumber
        {
            get { return houseNumber; }

            set
            {
                if (Checknumber(houseNumber.ToString()))
                    houseNumber = value;
                else throw new Exception();
            }
        }
        public string StreetName
        {
            get => streetName;
            set
            {
                if (CheckStreetNameLength(value))
                {
                    streetName = value;
                }
            }
        }
        public string TownName
        {
            get => townName;
            set
            {
                if (CheckNameLength(value))
                {
                    townName = value;
                }
            }
        }

        public string PostCode
        {
            get { return postCode; }

            set
            {
                if (CheckPostcode(value))
                    postCode = value;
                else throw new Exception();
            }
        }
        public string ClientContactNo
        {
            get => clientContactNo;
            set
            {
                if (CheckLength(value))
                {
                    clientContactNo = value;
                }
                else
                    throw new Exception();
            }

        }
        public DateTime EventDate
        {
            get => eventDate;
            set
            {
                if (CheckDate(value))
                {
                    eventDate = value;
                }
                else
                    throw new Exception("Event Date must be after setup date");
            }
        }
        public DateTime SetupDate { get => setupDate; set => setupDate = value; }
        public string EmployeeName
        {
            get => employeeName;
            set
            {
                if (CheckNameLength(value))
                {
                    employeeName = value;
                }
            }
        }
    }
}
