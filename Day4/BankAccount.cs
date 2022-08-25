using System;

namespace Day4
{
    class BankAccount
    {
        string depositer_name = "No name";
        int account_no;
        string account_type = "Checking";
        float account_balance;

        public BankAccount()
        {
            account_no = 0;
            account_balance = 0;
        }
        public BankAccount(string _name, int _account_no, string _account_type, float _account_balance)
        {
            SetName(_name);
            SetAccountNo(_account_no);
            SetAccountType(_account_type);
            SetAccountBalance(_account_balance);
        }
        public void SetName(string _name)
        {
            if (_name.Length >=10)
                depositer_name = _name;
            else
                Console.WriteLine("Not a valid name!");
        }
        public void SetAccountType(String _type)
        {
            account_type = _type;
        }
        public void SetAccountNo(int _num)
        {
            if (_num > 1000000 )
                account_no = _num;
            else
                Console.WriteLine("Not a valid account number!");
        }
        public void SetAccountBalance(float _balanace)
        {
            if (account_balance >= 0)
                account_balance = _balanace;
            else
                Console.WriteLine("Not a valid balance!");
        }
        public string GetDepositorName()
        {
            return depositer_name;
        }
        public string GetAccountType()
        {
            return account_type;
        }
        public int GetAccountNo()
        {
            return account_no;
        }
        public float GetAccountBalance()
        {
            return account_balance;
        }
        public void AccountInfo()
        {
            Console.WriteLine($"{depositer_name} has {account_type} account ,no: {account_no} and its balance is {account_balance}$.");
        }
    }
}
