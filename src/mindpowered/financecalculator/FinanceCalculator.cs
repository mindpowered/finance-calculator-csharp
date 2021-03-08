/**
 * Copyright Mind Powered Corporation 2020
 * 
 * https://mindpowered.dev/
 */

using System.Collections.Generic;

/**
 * A library for performing various finance calculations
 */
namespace mindpowered.financecalculator {
	public delegate void MyCallbackDelegate(object o);

	public class FinanceCalculator
	{
		public FinanceCalculator()
		{
			global::maglev.MagLev bus = global::maglev.MagLev.getInstance("default");
			global::financecalculator.FinanceCalculator myinstance = new global::financecalculator.FinanceCalculator(bus);
		}

		/**
		 * Calculate present value of future money
		 * @param futureValue Future Value
		 * @param numPeriods Number of Periods
		 * @param interestRate Interest Rate
		 * @return {object} object containing Present Value and Total Interest
		*/
		public object PresentValueOfFutureMoney(double futureValue, double numPeriods, double interestRate)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(futureValue);
			args.push(numPeriods);
			args.push(interestRate);
			object ret = null;
			MyCallbackDelegate async_delegate = delegate (object async_ret) { ret = (object) async_ret; };
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("FinanceCalculator.PresentValueOfFutureMoney", args, async_callback);
			return ret;
		}

		/**
		 * Calculate the present value of future deposits
		 * @param numPeriods Number of Periods
		 * @param interestRate Interest Rate
		 * @param depositAmount Periodic Deposit Amount
		 * @param depositAtBeginning Periodic Deposits made at beginning of period
		 * @return {object} object containing Present Value, Total Principal, and Total Interest
		*/
		public object PresentValueOfDeposits(double numPeriods, double interestRate, double depositAmount, bool depositAtBeginning)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(numPeriods);
			args.push(interestRate);
			args.push(depositAmount);
			args.push(depositAtBeginning);
			object ret = null;
			MyCallbackDelegate async_delegate = delegate (object async_ret) { ret = (object) async_ret; };
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("FinanceCalculator.PresentValueOfDeposits", args, async_callback);
			return ret;
		}

		/**
		 * Calculate the future value of money and/or deposits
		 * @param presentValue Present Value
		 * @param numPeriods Number of Periods
		 * @param interestRate Interest rate as a percentage
		 * @param timesCompoundedPerPeriod Times interest is compounded per period
		 * @param depositAmount Periodic Deposit Amount
		 * @param depositAtBeginning Periodic Deposits made at beginning of period
		 * @return {object} object containing Future Value and Total Interest
		*/
		public object FutureValue(double presentValue, double numPeriods, double interestRate, double timesCompoundedPerPeriod, double depositAmount, bool depositAtBeginning)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(presentValue);
			args.push(numPeriods);
			args.push(interestRate);
			args.push(timesCompoundedPerPeriod);
			args.push(depositAmount);
			args.push(depositAtBeginning);
			object ret = null;
			MyCallbackDelegate async_delegate = delegate (object async_ret) { ret = (object) async_ret; };
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("FinanceCalculator.FutureValue", args, async_callback);
			return ret;
		}

		/**
		 * Calculate net present value
		 * @param initialInvestment Initial Investment
		 * @param discountRate Discount Rate (eg. Interest Rate)
		 * @param timesCompoundedPerPeriod Times discount/interest is compounded per period
		 * @param cashFlowsAtBeginning 
		 * @param cashFlow List of cash flows per period
		 * @return {double} Net Present Value
		*/
		public double NetPresentValue(double initialInvestment, double discountRate, double timesCompoundedPerPeriod, double cashFlowsAtBeginning, object[] cashFlow)
		{
			global::maglev.MagLevCs mybus = global::maglev.MagLevCs.getInstance("default");
			global::Array<object> args = new global::Array<object>();
			args.push(initialInvestment);
			args.push(discountRate);
			args.push(timesCompoundedPerPeriod);
			args.push(cashFlowsAtBeginning);
			args.push(cashFlow);
			double ret = 0;
			MyCallbackDelegate async_delegate = delegate (object async_ret) { ret = (double) async_ret; };
			global::haxe.lang.Function async_callback = global::maglev.MagLevCs.callbackDelegateToHaxeFunction(async_delegate);
			mybus.call("FinanceCalculator.NetPresentValue", args, async_callback);
			return ret;
		}

	}
}

