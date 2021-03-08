// Generated by Haxe 4.1.1

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace financecalculator {
	public class FinCalc : global::haxe.lang.HxObject {
		
		static FinCalc() {
			unchecked{
				#line 3 "/my-component/src/financecalculator/FinCalc.hx"
				global::haxe.lang.FieldLookup.addFields(new int[]{530154542, 1580406414, 1932938041}, new string[]{"futureValue", "totalInterest", "totalDeposits"});
			}
		}
		#line default
		
		public FinCalc(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public FinCalc() {
			#line 5 "/my-component/src/financecalculator/FinCalc.hx"
			global::financecalculator.FinCalc.__hx_ctor_financecalculator_FinCalc(this);
		}
		#line default
		
		protected static void __hx_ctor_financecalculator_FinCalc(global::financecalculator.FinCalc __hx_this) {
		}
		
		
		public virtual object futureValue(double presentValue, int numPeriods, double interestRate, int timesCompoundedPerPeriod, double depositAmount, bool depositAtBeginning) {
			unchecked {
				#line 8 "/my-component/src/financecalculator/FinCalc.hx"
				double ir = ( interestRate / 100.0 );
				double fvps = ( presentValue * global::System.Math.Pow(((double) (( 1 + ir )) ), ((double) (numPeriods) )) );
				#line 10 "/my-component/src/financecalculator/FinCalc.hx"
				double fv = ( depositAmount / ir );
				fv *= ( global::System.Math.Pow(((double) (( 1 + ir )) ), ((double) (numPeriods) )) - 1.0 );
				#line 12 "/my-component/src/financecalculator/FinCalc.hx"
				if (depositAtBeginning) {
					#line 13 "/my-component/src/financecalculator/FinCalc.hx"
					fv *= ( 1.0 + ir );
				}
				
				#line 15 "/my-component/src/financecalculator/FinCalc.hx"
				double totalDeposits = ( ( numPeriods * depositAmount ) + presentValue );
				double futureValue = ( fv + fvps );
				#line 17 "/my-component/src/financecalculator/FinCalc.hx"
				double totalInterest = ( futureValue - totalDeposits );
				futureValue = ( global::System.Math.Floor(((double) (( ( futureValue * 100.0 ) + 0.5 )) )) / 100.0 );
				#line 19 "/my-component/src/financecalculator/FinCalc.hx"
				totalInterest = ( global::System.Math.Floor(((double) (( ( totalInterest * 100.0 ) + 0.5 )) )) / 100.0 );
				totalDeposits = ( global::System.Math.Floor(((double) (( ( totalDeposits * 100.0 ) + 0.5 )) )) / 100.0 );
				#line 21 "/my-component/src/financecalculator/FinCalc.hx"
				return new global::haxe.lang.DynamicObject(new int[]{}, new object[]{}, new int[]{530154542, 1580406414, 1932938041}, new double[]{futureValue, totalInterest, totalDeposits});
			}
			#line default
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				#line 3 "/my-component/src/financecalculator/FinCalc.hx"
				switch (hash) {
					case 530154542:
					{
						#line 3 "/my-component/src/financecalculator/FinCalc.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "futureValue", 530154542)) );
					}
					
					
					default:
					{
						#line 3 "/my-component/src/financecalculator/FinCalc.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_invokeField(string field, int hash, object[] dynargs) {
			unchecked {
				#line 3 "/my-component/src/financecalculator/FinCalc.hx"
				switch (hash) {
					case 530154542:
					{
						#line 3 "/my-component/src/financecalculator/FinCalc.hx"
						return this.futureValue(((double) (global::haxe.lang.Runtime.toDouble(dynargs[0])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ), ((double) (global::haxe.lang.Runtime.toDouble(dynargs[2])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[3])) ), ((double) (global::haxe.lang.Runtime.toDouble(dynargs[4])) ), global::haxe.lang.Runtime.toBool(dynargs[5]));
					}
					
					
					default:
					{
						#line 3 "/my-component/src/financecalculator/FinCalc.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
			}
			#line default
		}
		
		
	}
}

