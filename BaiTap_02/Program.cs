using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap_02
{
    class Account
    {
        private string id;
        private string name;
        private int balance;
        public Account(string id, string name, int balance)
        {
            this.id = id;
            this.name = name;
            this.balance = balance;
        }
        public string getId()
        {
            return id;
        }
        public string getName()
        {
            return name;
        }
        public int getBalance()
        {
            return balance;
        }
        public void credit(int amount)
        {
            if(amount>0)
            balance += amount;
        }
        public void derit(int amount)
        {
            if (amount <= balance)
                balance -= amount;
            else 
                Console.WriteLine("So tien vuot qua so du. Rut tien khong thanh cong");
        }     
        public void tranferTo(Account acc, int amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                acc.balance += amount;
            }
            else
            {
                Console.WriteLine("So tien vuot qua so du. Chuyen khoan khong thanh cong");
            }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Account my = new Account("19001081", "Le Van Thang", 400);
            Account myfriend = new Account("19001081", "Cao Thanh Phu", 50);
            Console.WriteLine("-----Thong tin 2 tài khoan ban dau-----");
            Console.WriteLine("My Account: [ id: {0}, name: {1}, balance:{2}]", 
                my.getId(), my.getName(), my.getBalance());
            Console.WriteLine("My Friend Account: [ id: {0}, name: {1}, balance:{2}]",
                myfriend.getId(), myfriend.getName(), myfriend.getBalance());
            //Rut tien
            my.derit(150);
            my.tranferTo(myfriend, 50);
            //Ket qua sau khi thuc hien mot hanh vi( nạp, rut, chuyen khoan)
            Console.WriteLine("-----Thong tin 2 tài khoan ban dau-----");
            Console.WriteLine("My Account: [ id: {0}, name: {1}, balance:{2}]",
                my.getId(), my.getName(), my.getBalance());
            Console.WriteLine("My Friend Account: [ id: {0}, name: {1}, balance:{2}]",
                myfriend.getId(), myfriend.getName(), myfriend.getBalance());
            Console.ReadLine();

        }
    }
}
