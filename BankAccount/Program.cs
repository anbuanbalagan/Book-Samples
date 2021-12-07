using System;

namespace BankAccounts
{
	public class BankAccount
	{
		private double balance;

		public BankAccount(double initDeposit)
		{
			setBalance(initDeposit);
		}

		public void depositFunds(double amount)
		{
			setBalance(getBalance() + amount);
		}

		public double getBalance()
		{
			return balance;
		}

		protected void setBalance(double newBalance)
		{
			balance = newBalance;
		}

		public double withdrawFunds(double amount)
		{
			if(amount >= balance)
			{
				amount = balance;
			}

			setBalance(getBalance() - amount);
			return amount;
		}
	}

	public class SavingsAccount : BankAccount
	{
		private double interestRate;

		public SavingsAccount(double initBalance, double interestRate) : base(initBalance)
		{
			setInterestRate(interestRate);
		}

		public void addInterest()
		{
			double balance = getBalance();
			double rate = getInterestRate();
			double interest = balance * rate;
			double new_balance = balance + interest;
			setBalance(new_balance);
		}

		public void setInterestRate(double interestRate)
		{
			this.interestRate = interestRate;
		}

		public double getInterestRate()
		{
			return interestRate;
		}
	}

	/*public class TimedMaturityAccount : SavingsAccount
	 {
		private bool mature;
		private double feeRate;

		public TimedMaturityAccount(double initBalance, double interestRate,double feeRate) : base(initBalance,interestRate)
		{
			setFeeRate(feeRate);
		}

		public double  withdrawFunds(double amount)  
		{
			withdrawFunds(amount);
			if(!isMature())
			{
				double charge = amount * getFeeRate();
				amount = amount - charge;
			}
			return amount;
		}
		
		public bool isMature()
		{
			return mature;
		}

		public void mature()
		{
			mature = true;
		}
		
		public double getFeeRate()
		{
			return feeRate;
		}
	
		public void setFeeRate(double rate)
		{
			feeRate = rate;
		}
	 }*/

	public class CheckingAccount : BankAccount
	{

		private int monthlyQuota;
		private int transactionCount;
		private double fee;

		public CheckingAccount(double initDeposit, int trans, double fee) : base(initDeposit)
		{
			setMonthlyQuota(trans);
			setFee(fee);
		}

		public double withdrawFunds(double amount)
		{
			transactionCount++;
			return base.withdrawFunds(amount);
		}

		public void accessFees()
		{
			int extra = getTransactionCount() - getMonthlyQuota();
			if(extra > 0)
			{
				double total_fee = extra * getFee();
				double balance = getBalance() - total_fee;
				setBalance(balance);
			}
			transactionCount = 0;
		}

		public double getFee()
		{
			return fee;
		}

		public void setFee(double fee)
		{
			this.fee = fee;
		}

		public int getMonthlyQuota()
		{
			return monthlyQuota;
		}

		public void setMonthlyQuota(int quota)
		{
			monthlyQuota = quota;
		}

		public int getTransactionCount()
		{
			return transactionCount;
		}
	}

	public class OverdraftAccount : BankAccount
	{
		private double creditRate;

		public OverdraftAccount(double initDeposit, double rate) : base(initDeposit)
		{
			setCreditRate(rate);
		}

		public void chargeInterest()
		{
			double balance = getBalance();
			if(balance < 1000)
			{
				double charge = balance * getCreditRate();
				setBalance(balance + charge);
			}
		}

		public double getCreditRate()
		{
			return creditRate;
		}

		public void setCreditRate(double rate)
		{
			creditRate = rate;
		}

		public double withdrawFunds(double amount)
		{
			setBalance(getBalance() - amount);
			return amount;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			OverdraftAccount overdraftAccount = new OverdraftAccount(1000, 5);
			CheckingAccount checkingAccount = new CheckingAccount(1000, 5, 10.5);
			Console.WriteLine("Enter the Deposit Amount");
			int deposit = int.Parse(Console.ReadLine());
			overdraftAccount.depositFunds(deposit);
			Console.WriteLine("Balance Amount is : $" + overdraftAccount.getBalance());

			Console.WriteLine("Enter the withdraw Amount");
			int withdraw = int.Parse(Console.ReadLine());
			overdraftAccount.withdrawFunds(withdraw);
			Console.WriteLine("Balance Amount is : $" + overdraftAccount.getBalance());

			checkingAccount.accessFees();
			Console.WriteLine("Balance Amount is : $" + checkingAccount.getBalance());
		}
	}
}
