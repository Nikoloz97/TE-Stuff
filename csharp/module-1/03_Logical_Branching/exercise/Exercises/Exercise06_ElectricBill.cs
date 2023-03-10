using System;
using System.Collections.Generic;
using System.Text;

namespace TechElevator.Exercises.LogicalBranching
{
    /*
     * Tech Electric is an energy provider with a simple pricing model:
     *      The first 100 units (basic service limit) are $0.20 per unit (basic service rate).
     *      Anything more than the basic service limit is $0.25 per unit (excess service rate).
     *
     * The following problems have you calculate a customer's total for their energy usage.
     */

    public class ElectricBill
    {
        // You can use these constants in your solutions.
        private const double BaseServiceRate = 0.20;
        private const double BasicServiceLimit = 100.0;
        private const double ExcessServiceRate = 0.25;
        private const double RenewableEnergyDiscount = 0.05;

        /*
         * Using Tech Electric's simple pricing model, calculate a customer's bill for the units
         * they've used.
         *
         * calculateElectricBill(50) ➔ 10.0
         * calculateElectricBill(63.7) ➔ 12.74
         * calculateElectricBill(110) ➔ 22.5
         */
        public double CalculateElectricBill(double unitsUsed)
        {
            if (unitsUsed <= BasicServiceLimit)
            {
                return unitsUsed * BaseServiceRate;
            }
            return ((unitsUsed - BasicServiceLimit) * ExcessServiceRate) + (BasicServiceLimit * BaseServiceRate);
        }

        /*
         * Tech Electric realized some of their customers have renewable energy like solar panels.
         * to reward those customers, Tech Electric gives them a 5% renewable energy discount off their bill.
         *
         * Using Tech Electric's simple pricing model, calculate a customer's bill, applying the additional
         * renewable energy discount if they have renewable energy.
         *
         * calculateElectricBill(50, false) ➔ 10.0
         * calculateElectricBill(50, true) ➔ 9.5
         * calculateElectricBill(110, true) ➔ 21.375
         */
        public double CalculateElectricBill(double unitsUsed, bool hasRenewableEnergy)
        {
                if (unitsUsed <= BasicServiceLimit && hasRenewableEnergy == true)
                {
                    return (unitsUsed * BaseServiceRate) - ((unitsUsed * BaseServiceRate) * RenewableEnergyDiscount);
                }
                if (unitsUsed <= BasicServiceLimit && hasRenewableEnergy == false)
                {
                    return unitsUsed * BaseServiceRate;
                }
                if (unitsUsed > BasicServiceLimit && hasRenewableEnergy == true)
                {
                return ((unitsUsed - BasicServiceLimit) * ExcessServiceRate) + (BasicServiceLimit * BaseServiceRate) - ((((unitsUsed - BasicServiceLimit) * ExcessServiceRate) + (BasicServiceLimit * BaseServiceRate)) * RenewableEnergyDiscount);
                }
            return ((unitsUsed - BasicServiceLimit) * ExcessServiceRate) + (BasicServiceLimit * BaseServiceRate);

        }

        /*
         * Tech Electric now allows customers with renewable energy to return electricity back into the grid,
         * and has accordingly adjusted the rules around the renewable energy discount.
         *
         * The difference between the units used by the customer and the units returned by them is the net usage.
         *
         * Using Tech Electric's simple pricing model, calculate a customer's bill based upon their net usage.
         * Apply the renewable energy discount. Customers with a "credit" bill (a negative bill amount), or who
         * have not contributed back to the grid (zero returned units) are not eligible for the renewable energy
         * discount.
         *
         * Implement the logic to calculate a customer's bill when provided with the number of units used and
         * units returned.
         *
         * calculateElectricBill(50, 0) ➔ 10.0
         * calculateElectricBill(50, 4) ➔ 8.74
         * calculateElectricBill(50, 60) ➔ -2.0
         * calculateElectricBill(110, 6) ➔ 19.95
         * calculateElectricBill(110, 20) ➔ 17.1
         * calculateElectricBill(110, 120) ➔ -2.0
         */
        public double CalculateElectricBill(double unitsUsed, double unitsReturned)
        {
            if ((unitsUsed - unitsReturned) > 0 && unitsReturned > 0)
            {
                if ((unitsUsed - unitsReturned) <= BasicServiceLimit)
                {
                    return ((unitsUsed - unitsReturned) * BaseServiceRate) - (((unitsUsed - unitsReturned) * BaseServiceRate) * 0.05);
                }

                if ((unitsUsed - unitsReturned) > BasicServiceLimit)
                {
                    return ((BasicServiceLimit * BaseServiceRate) + ((unitsUsed - unitsReturned) - 100) * ExcessServiceRate) - (((BasicServiceLimit * BaseServiceRate) + ((unitsUsed - unitsReturned) - 100) * ExcessServiceRate) * 0.05);
                }
            }
            if ((unitsUsed - unitsReturned) <= 100)
            {
                return (unitsUsed - unitsReturned) * BaseServiceRate;
            }
            if ((unitsUsed - unitsReturned) > 100)
            {
                return ((100 * BaseServiceRate) + ((unitsUsed - unitsReturned) - 100) * ExcessServiceRate);
        
            }
            return 0;
        }
    }
}
