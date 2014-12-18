namespace CalculationOfProfit
{
    using System;
    /// <summary>
    /// Опорный класс для заполнения данных.
    /// </summary>
    public class Data
    {
        /// <summary>
        /// Время проведения тестов.
        /// </summary>
        public DateTime DateOfTest;

        /// <summary>
        /// Длительность этапов ЖЦ.
        /// </summary>
        public int[] T;

        /// <summary>
        /// Объемы продаж в переломных точках.
        /// </summary>
        public int[] V;

        /// <summary>
        /// Цена изделия.
        /// </summary>
        public double Price;

        /// <summary>
        /// Издержки.
        /// </summary>
        public double Costs;

        /// <summary>
        /// Прибыль на этапах ЖЦ.
        /// </summary>
        public double[] Profit;

        /// <summary>
        /// Суммарная прибыль.
        /// </summary>
        public double TotalProfit;
    }
}
