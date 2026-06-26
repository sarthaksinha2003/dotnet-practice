using System;

namespace MyFirstProject
{
    public class Encapsulation
    {
        private int balance;
        public Encapsulation()
        {
            balance = 0;
        }
        public int getBalance(){
            return this.balance;
        }
        public void setBalance(int balance)
        {
            if (balance < 0)
            {
                throw new Exception("Please Pass a Positive Value");
            }
            else
            {
                this.balance = balance;
            }
        }
        public void addBalance(int amount)
        {
            if (amount < 0)
            {
                throw new Exception("Please Pass a Positive Value");
            }
            else
            {
                this.balance += amount;
            }
        }
    }
}
