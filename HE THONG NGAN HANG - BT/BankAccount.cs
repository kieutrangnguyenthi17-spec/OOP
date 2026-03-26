using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HE_THONG_NGAN_HANG
{
    public abstract class BankAccount
    {
        //thuoc tinh
        private String AccountNumber;
        private String OwnerName;
        private double Balance;
        private DateTime CreatedAt;
        //ham dung - constructor
        public BankAccount(String AccountNumber,String OwnerName, double Balance, DateTime CreatedAt)
        {
            this.AccountNumber=AccountNumber;
            this.OwnerName=OwnerName;
            this.Balance= Balance;
            this.CreatedAt=CreatedAt;
        }
        public void Deposit(double amount) // nap tien
        {
            if(amount <0)
            {
                throw new ArgumentException("So tien nap phai >0");
                Balance+=amount; //so du moi=so du cu+so tien nap
            }
        }
        public virtual void Withdraw(double amount)
        {
            if(amount <=0)
            {
                throw new ArgumentException("So tien rut phai lon hon 0");

            }
            if (amount>Balance)
            {
                throw new IndexOutOfRangeException("So du khong du");

            }
            Balance-=amount;
        }


    }
}
