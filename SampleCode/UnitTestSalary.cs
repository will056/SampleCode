using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleCode
{
    #region Для понимания структуры входных данных
    public class DataOperation
    {
        /// <summary>
        /// Выполненное количество
        /// </summary>
        public int Count { get; set; }
        public double PriceForOne { get; set; }
        public bool Hourly { get; set; }
        /// <summary>
        /// Переработка, зп за операцию умножается на коэффициент
        /// </summary>
        public bool PartTime { get; set; }
        public bool Coaching;
        public decimal CostPerHour { get; set; }
        /// <summary>
        /// Длительность операции
        /// </summary>
        public TimeSpan DuringOperation { get; set; }

    }

    public class DataForCalcSalary
    {

        public TimeSpan StartWorkingShift { get; set; }
        public TimeSpan EndWorkingShift { get; set; }
        public bool Dinner { get; set; }
        public string StatusWorkDoneForShift { get; set; }
        public decimal SpecialCostWordDoneForShift { get; set; }
        public List<DataOperation> OperationsWorkingShift { get; set; }


        public DataForCalcSalary()
        {
            OperationsWorkingShift = new List<DataOperation>();
        }
    }
    #endregion

    //Unit test модуля расчета ЗП 
    [TestFixture]
    public class Test
    {
        //Период обучения
        [Test]
        public void IsTraining()
        {
            //=562,5 руб
            DataForCalcSalary data1A = new DataForCalcSalary();
            data1A.StatusWorkDoneForShift = "is_training";
            data1A.Dinner = true;
            data1A.StartWorkingShift = new TimeSpan(8, 0, 0);
            data1A.EndWorkingShift = new TimeSpan(16, 0, 0);
            data1A.SpecialCostWordDoneForShift = 75;
            data1A.OperationsWorkingShift.Add(new DataOperation()
            {
                Count = 100,
                PriceForOne = 0.2,
                CostPerHour = 70,
                Hourly = false,
                PartTime = false,
                DuringOperation = new TimeSpan(8, 0, 0)
            });
            var salary1A = CalculateSalary(data1A);

            // 880 руб
            DataForCalcSalary data1B = new DataForCalcSalary();
            data1B.StatusWorkDoneForShift = "is_training";
            data1B.Dinner = true;
            data1B.StartWorkingShift = new TimeSpan(8, 0, 0);
            data1B.EndWorkingShift = new TimeSpan(20, 0, 0);
            data1B.SpecialCostWordDoneForShift = 80;

            data1B.OperationsWorkingShift.Add(new DataOperation()
            {
                Count = 100,
                PriceForOne = 1.2,
                CostPerHour = 105,
                Hourly = true,
                PartTime = false,
                DuringOperation = new TimeSpan(12, 1, 0)
            });
            var salary1B = CalculateSalary(data1B);

            //37.5
            DataForCalcSalary data1C = new DataForCalcSalary();
            data1C.StartWorkingShift = new TimeSpan(0, 0, 0);
            data1C.EndWorkingShift = new TimeSpan(1, 0, 0);
            data1C.Dinner = true;
            data1C.StatusWorkDoneForShift = "is_training";
            data1C.SpecialCostWordDoneForShift = 75;

            data1C.OperationsWorkingShift.Add(new DataOperation()
            {
                Count = 1,
                PriceForOne = 2.0,
                CostPerHour = 70,
                Hourly = true,
                PartTime = false,
                DuringOperation = new TimeSpan(1, 0, 0)
            });
            var salary1C = CalculateSalary(data1C);

            // 862,5
            DataForCalcSalary data1D = new DataForCalcSalary();
            data1D.StatusWorkDoneForShift = "is_training";
            data1D.StartWorkingShift = new TimeSpan(0, 0, 0);
            data1D.EndWorkingShift = new TimeSpan(12, 0, 0);
            data1D.Dinner = false;

            data1D.OperationsWorkingShift.Add(
                new DataOperation()
                {
                    Count = 1,
                    PriceForOne = 1.0,
                    CostPerHour = 75,
                    Hourly = true,
                    PartTime = false,
                    DuringOperation = new TimeSpan(11, 20, 0)
                });
            var salary1D = CalculateSalary(data1D);

            // 570 руб
            DataForCalcSalary data1E = new DataForCalcSalary();
            data1E.StatusWorkDoneForShift = "is_training";
            data1E.StartWorkingShift = new TimeSpan(0, 0, 0);
            data1E.EndWorkingShift = new TimeSpan(0, 0, 0);
            data1E.Dinner = false;

            //3000
            data1E.OperationsWorkingShift.Add(new DataOperation()
            {
                Count = 1000,
                PriceForOne = 2.0,
                CostPerHour = 70,
                Hourly = false,
                PartTime = true,
                DuringOperation = new TimeSpan(1, 15, 0)
            });
            //2000
            data1E.OperationsWorkingShift.Add(new DataOperation()
            {
                Count = 1000,
                PriceForOne = 2.0,
                CostPerHour = 75,
                Hourly = false,
                PartTime = false,
                DuringOperation = new TimeSpan(1, 45, 0)
            });
            //2000
            data1E.OperationsWorkingShift.Add(new DataOperation()
            {
                Count = 1000,
                PriceForOne = 2.0,
                CostPerHour = 70,
                Hourly = false,
                PartTime = false,
                DuringOperation = new TimeSpan(5, 0, 0)
            });

            var salary1E = CalculateSalary(data1E);

            // 820 руб
            DataForCalcSalary data1F = new DataForCalcSalary();
            data1F.StatusWorkDoneForShift = "is_training";
            data1F.StartWorkingShift = new TimeSpan(01, 0, 0);
            data1F.EndWorkingShift = new TimeSpan(0, 0, 0);
            data1F.Dinner = false;
            data1F.SpecialCostWordDoneForShift = 80;

            data1F.OperationsWorkingShift.Add(new DataOperation()
            {
                Count = 1000,
                PriceForOne = 2.0,
                CostPerHour = 70,
                Hourly = false,
                PartTime = false,
                DuringOperation = new TimeSpan(1, 15, 0)
            });
            //225
            data1F.OperationsWorkingShift.Add(new DataOperation()
            {
                Count = 1000,
                PriceForOne = 2.0,
                CostPerHour = 75,
                Hourly = false,
                PartTime = true,
                DuringOperation = new TimeSpan(1, 45, 0)
            });
            //525
            data1F.OperationsWorkingShift.Add(new DataOperation()
            {
                Count = 1000,
                PriceForOne = 2.0,
                CostPerHour = 70,
                Hourly = false,
                PartTime = true,
                DuringOperation = new TimeSpan(5, 0, 0)
            });

            var salary1F = CalculateSalary(data1F);


            // 920 руб
            DataForCalcSalary data1H = new DataForCalcSalary();
            data1H.StatusWorkDoneForShift = "is_training";
            data1H.StartWorkingShift = new TimeSpan(01, 0, 0);
            data1H.EndWorkingShift = new TimeSpan(0, 0, 0);
            data1H.Dinner = false;
            data1H.SpecialCostWordDoneForShift = 80;

            data1H.OperationsWorkingShift.Add(new DataOperation()
            {
                Count = 1,
                PriceForOne = 2.0,
                CostPerHour = 70,
                Hourly = false,
                PartTime = false,
                DuringOperation = new TimeSpan(1, 15, 0)
            });
            //225
            data1H.OperationsWorkingShift.Add(new DataOperation()
            {
                Count = 1,
                PriceForOne = 2.0,
                CostPerHour = 75,
                Hourly = false,
                PartTime = true,
                DuringOperation = new TimeSpan(1, 45, 0)
            });
            //525
            data1H.OperationsWorkingShift.Add(new DataOperation()
            {
                Count = 1,
                PriceForOne = 2.0,
                CostPerHour = 70,
                Hourly = false,
                PartTime = true,
                DuringOperation = new TimeSpan(5, 0, 0)
            });

            var salary1H = CalculateSalary(data1H);

            Assert.IsTrue(562.5m == salary1A && 880 == salary1B && 37.5m == salary1C && 862.5m == salary1D && 7000 == salary1E && 8000m == salary1F && 920 == salary1H);
        }

        //Период работы
        [Test]
        public void TestProbation()
        {
            //20
            DataForCalcSalary data1A = new DataForCalcSalary();
            data1A.StatusWorkDoneForShift = "probation";
            data1A.Dinner = true;
            data1A.StartWorkingShift = new TimeSpan(8, 0, 0);
            data1A.EndWorkingShift = new TimeSpan(16, 0, 0);
            data1A.OperationsWorkingShift.Add(new DataOperation()
            {
                Count = 100,
                PriceForOne = 0.2,
                CostPerHour = 70,
                Hourly = false,
                PartTime = false,
                DuringOperation = new TimeSpan(8, 0, 0)
            });
            var salary1A = CalculateSalary(data1A);


            // 1190
            DataForCalcSalary data1B = new DataForCalcSalary();
            data1B.StatusWorkDoneForShift = "probation";
            data1B.Dinner = true;
            data1B.StartWorkingShift = new TimeSpan(8, 0, 0);
            data1B.EndWorkingShift = new TimeSpan(20, 0, 0);

            //1260
            data1B.OperationsWorkingShift.Add(new DataOperation()
            {
                Count = 100,
                PriceForOne = 1.2,
                CostPerHour = 105,
                Hourly = true,
                PartTime = false,
                DuringOperation = new TimeSpan(12, 0, 0)
            });
            var salary1B = CalculateSalary(data1B);

            //65
            DataForCalcSalary data1C = new DataForCalcSalary();
            data1C.StartWorkingShift = new TimeSpan(8, 0, 0);
            data1C.EndWorkingShift = new TimeSpan(15, 0, 0);
            data1C.Dinner = true;
            data1C.StatusWorkDoneForShift = "probation";

            data1C.OperationsWorkingShift.Add(new DataOperation()
            {
                Count = 50,
                PriceForOne = 2.0,
                CostPerHour = 75,
                Hourly = true,
                PartTime = false,
                DuringOperation = new TimeSpan(1, 0, 0)
            });
            var salary1C = CalculateSalary(data1C);

            //2000 обед не вычетаю т.к. нет в смене работ по времени
            DataForCalcSalary data1I = new DataForCalcSalary();
            data1I.StartWorkingShift = new TimeSpan(20, 0, 0);
            data1I.EndWorkingShift = new TimeSpan(8, 0, 0);
            data1I.Dinner = true;
            data1I.StatusWorkDoneForShift = "probation";

            data1I.OperationsWorkingShift.Add(new DataOperation()
            {
                Count = 1000,
                PriceForOne = 2.0,
                CostPerHour = 75,
                Hourly = false,
                PartTime = false,
                DuringOperation = new TimeSpan(1, 0, 0)
            });
            var salary1I = CalculateSalary(data1I);

            // 1000
            DataForCalcSalary data1D = new DataForCalcSalary();
            data1D.StatusWorkDoneForShift = "probation";
            data1D.StartWorkingShift = new TimeSpan(0, 0, 0);
            data1D.EndWorkingShift = new TimeSpan(0, 0, 1);
            data1D.Dinner = false;

            data1D.OperationsWorkingShift.Add(new DataOperation()
            {
                Count = 1000,
                PriceForOne = 1.0,
                CostPerHour = 75,
                Hourly = true,
                PartTime = false,
                DuringOperation = new TimeSpan(11, 20, 0)
            });
            var salary1D = CalculateSalary(data1D);

            // 3985
            DataForCalcSalary data1E = new DataForCalcSalary();
            data1E.StatusWorkDoneForShift = "probation";
            data1E.StartWorkingShift = new TimeSpan(20, 0, 0);
            data1E.EndWorkingShift = new TimeSpan(20, 0, 0);
            data1E.Dinner = true;

            data1E.OperationsWorkingShift.Add(new DataOperation()
            {
                Count = 1000,
                PriceForOne = 2.0,
                CostPerHour = 70,
                Hourly = false,
                PartTime = true,
                DuringOperation = new TimeSpan(0, 0, 0)
            });

            //
            data1E.OperationsWorkingShift.Add(new DataOperation()
            {
                Count = 1000,
                PriceForOne = 2.0,
                CostPerHour = 75,
                Hourly = true,
                PartTime = true,
                DuringOperation = new TimeSpan(10, 0, 0)
            });

            var salary1E = CalculateSalary(data1E);

            //770 (по факту 652 но это < 770 за 11 часа т.к. был обед)
            DataForCalcSalary data1H = new DataForCalcSalary();
            data1H.StatusWorkDoneForShift = "probation";
            data1H.StartWorkingShift = new TimeSpan(8, 0, 0);
            data1H.EndWorkingShift = new TimeSpan(20, 0, 0);
            data1H.Dinner = true;

            data1H.OperationsWorkingShift.Add(new DataOperation()
            {
                Count = 1,
                PriceForOne = 2.0,
                CostPerHour = 70,
                Hourly = false,
                PartTime = false,
                DuringOperation = new TimeSpan(0, 0, 0)
            });

            //
            data1H.OperationsWorkingShift.Add(new DataOperation()
            {
                Count = 100,
                PriceForOne = 2.0,
                CostPerHour = 75,
                Hourly = true,
                PartTime = false,
                DuringOperation = new TimeSpan(6, 0, 0)
            });

            //
            data1H.OperationsWorkingShift.Add(new DataOperation()
            {
                Count = 100,
                PriceForOne = 2.0,
                CostPerHour = 70,
                Hourly = false,
                PartTime = false,
                DuringOperation = new TimeSpan(6, 0, 0)
            });

            var salary1H = CalculateSalary(data1H);

            // 2225 (по факту 2225 р но это < 1680 за 24 часа т.к.  обеда не было)
            DataForCalcSalary data1F = new DataForCalcSalary();
            data1F.StatusWorkDoneForShift = "probation";
            data1F.StartWorkingShift = new TimeSpan(20, 0, 0);
            data1F.EndWorkingShift = new TimeSpan(20, 0, 0);
            data1F.Dinner = false;

            data1F.OperationsWorkingShift.Add(new DataOperation()
            {
                Count = 100,
                PriceForOne = 2.0,
                CostPerHour = 70,
                Hourly = false,
                PartTime = true,
                DuringOperation = new TimeSpan(0, 0, 0)
            });

            //
            data1F.OperationsWorkingShift.Add(new DataOperation()
            {
                Count = 100,
                PriceForOne = 2.0,
                CostPerHour = 75,
                Hourly = true,
                PartTime = true,
                DuringOperation = new TimeSpan(10, 0, 0)
            });

            //
            data1F.OperationsWorkingShift.Add(new DataOperation()
            {
                Count = 100,
                PriceForOne = 2.0,
                CostPerHour = 70,
                Hourly = false,
                PartTime = false,
                DuringOperation = new TimeSpan(10, 0, 0)
            });

            //
            data1F.OperationsWorkingShift.Add(new DataOperation()
            {
                Count = 100,
                PriceForOne = 2.0,
                CostPerHour = 70,
                Hourly = false,
                PartTime = false,
                DuringOperation = new TimeSpan(10, 0, 0)
            });

            //
            data1F.OperationsWorkingShift.Add(new DataOperation()
            {
                Count = 100,
                PriceForOne = 2.0,
                CostPerHour = 70,
                Hourly = false,
                PartTime = false,
                DuringOperation = new TimeSpan(10, 0, 0)
            });

            //
            data1F.OperationsWorkingShift.Add(new DataOperation()
            {
                Count = 100,
                PriceForOne = 2.0,
                CostPerHour = 70,
                Hourly = false,
                PartTime = false,
                DuringOperation = new TimeSpan(10, 0, 0)
            });

            var salary1F = CalculateSalary(data1F);

            // 2035
            DataForCalcSalary data1K = new DataForCalcSalary();
            data1K.StatusWorkDoneForShift = "probation";
            data1K.StartWorkingShift = new TimeSpan(20, 0, 0);
            data1K.EndWorkingShift = new TimeSpan(20, 0, 0);
            data1K.Dinner = false;

            data1K.OperationsWorkingShift.Add(new DataOperation()
            {
                Count = 1,
                PriceForOne = 2.0,
                CostPerHour = 70,
                Hourly = false,
                Coaching = true,
                PartTime = true,
                DuringOperation = new TimeSpan(2, 0, 0)
            });

            //
            data1K.OperationsWorkingShift.Add(new DataOperation()
            {
                Count = 100,
                PriceForOne = 2.0,
                CostPerHour = 75,
                Coaching = true,
                Hourly = true,
                PartTime = true,
                DuringOperation = new TimeSpan(10, 0, 0)
            });

            //
            data1K.OperationsWorkingShift.Add(new DataOperation()
            {
                Count = 100,
                PriceForOne = 2.0,
                CostPerHour = 70,
                Coaching = true,
                Hourly = false,
                PartTime = false,
                DuringOperation = new TimeSpan(10, 0, 0)
            });

            var salary1K = CalculateSalary(data1K);

            // 
            DataForCalcSalary data1J = new DataForCalcSalary();
            data1J.StatusWorkDoneForShift = "probation";
            data1J.StartWorkingShift = new TimeSpan(8, 0, 0);
            data1J.EndWorkingShift = new TimeSpan(21, 0, 0);
            data1J.Dinner = false;

            //96.25
            data1J.OperationsWorkingShift.Add(new DataOperation()
            {
                Count = 500,
                PriceForOne = 0.1925,
                CostPerHour = 70,
                Coaching = false,
                Hourly = false,
                PartTime = false,
                DuringOperation = new TimeSpan(0, 0, 0)
            });

            //51
            data1J.OperationsWorkingShift.Add(new DataOperation()
            {
                Count = 500,
                PriceForOne = 0.102666666,
                CostPerHour = 70,
                Coaching = true,
                Hourly = false,
                PartTime = false,
                DuringOperation = new TimeSpan(0, 30, 0)
            });

            //350
            data1J.OperationsWorkingShift.Add(new DataOperation()
            {
                Count = 2000,
                PriceForOne = 0.102666666,
                CostPerHour = 70,
                Coaching = true,
                Hourly = false,
                PartTime = false,
                DuringOperation = new TimeSpan(5, 0, 0)
            });

            var salary1J = CalculateSalary(data1J);

            // 4000 обед не учитывается, смене 2 операции и обе по шт.
            DataForCalcSalary data1L = new DataForCalcSalary();
            data1L.StatusWorkDoneForShift = "probation";
            data1L.StartWorkingShift = new TimeSpan(20, 0, 0);
            data1L.EndWorkingShift = new TimeSpan(20, 0, 0);
            data1L.Dinner = true;

            data1L.OperationsWorkingShift.Add(new DataOperation()
            {
                Count = 1000,
                PriceForOne = 2.0,
                CostPerHour = 70,
                Hourly = false,
                PartTime = false,
                DuringOperation = new TimeSpan(0, 0, 0)
            });

            data1L.OperationsWorkingShift.Add(new DataOperation()
            {
                Count = 1000,
                PriceForOne = 2.0,
                CostPerHour = 75,
                Hourly = false,
                PartTime = false,
                DuringOperation = new TimeSpan(10, 0, 0)
            });

            var salary1L = CalculateSalary(data1L);

            // 4000 обед не учитывается, смене 2 операции и обе по шт.
            DataForCalcSalary data1M = new DataForCalcSalary();
            data1M.StatusWorkDoneForShift = "probation";
            data1M.StartWorkingShift = new TimeSpan(20, 0, 0);
            data1M.EndWorkingShift = new TimeSpan(20, 0, 0);
            data1M.Dinner = false;

            data1M.OperationsWorkingShift.Add(new DataOperation()
            {
                Count = 1000,
                PriceForOne = 2.0,
                CostPerHour = 70,
                Hourly = false,
                PartTime = false,
                DuringOperation = new TimeSpan(0, 0, 0)
            });


            data1M.OperationsWorkingShift.Add(new DataOperation()
            {
                Count = 1000,
                PriceForOne = 2.0,
                CostPerHour = 75,
                Hourly = false,
                PartTime = false,
                DuringOperation = new TimeSpan(10, 0, 0)
            });

            var salary1M = CalculateSalary(data1L);

            //20
            DataForCalcSalary data1N = new DataForCalcSalary();
            data1N.StatusWorkDoneForShift = "probation";
            data1N.Dinner = true;
            data1N.StartWorkingShift = new TimeSpan(8, 0, 0);
            data1N.EndWorkingShift = new TimeSpan(16, 0, 0);
            data1N.SpecialCostWordDoneForShift = 80;

            data1N.OperationsWorkingShift.Add(new DataOperation()
            {
                Count = 100,
                PriceForOne = 0.2,
                CostPerHour = 70,
                Hourly = false,
                PartTime = false,
                DuringOperation = new TimeSpan(8, 0, 0)
            });
            var salary1N = CalculateSalary(data1N);

            DataForCalcSalary data1O = new DataForCalcSalary();
            data1O.StatusWorkDoneForShift = "probation";
            data1O.Dinner = true;
            data1O.StartWorkingShift = new TimeSpan(8, 0, 0);
            data1O.EndWorkingShift = new TimeSpan(20, 0, 0);
            data1O.SpecialCostWordDoneForShift = 80;

            data1O.OperationsWorkingShift.Add(new DataOperation()
            {
                Count = 100,
                PriceForOne = 1.2,
                CostPerHour = 105,
                Hourly = true,
                PartTime = false,
                DuringOperation = new TimeSpan(12, 0, 0)
            });
            var salary1O = CalculateSalary(data1O);


            // 3985
            DataForCalcSalary data1P = new DataForCalcSalary();
            data1P.StatusWorkDoneForShift = "probation";
            data1P.StartWorkingShift = new TimeSpan(20, 0, 0);
            data1P.EndWorkingShift = new TimeSpan(20, 0, 0);
            data1P.Dinner = true;
            data1P.SpecialCostWordDoneForShift = 80;

            //200
            data1P.OperationsWorkingShift.Add(new DataOperation()
            {
                Count = 1,
                PriceForOne = 2.0,
                CostPerHour = 70,
                Hourly = true,
                PartTime = false,
                DuringOperation = new TimeSpan(2, 35, 0)
            });

            //1000
            data1P.OperationsWorkingShift.Add(
                new DataOperation()
                {
                    Count = 500,
                    PriceForOne = 2.0,
                    CostPerHour = 75,
                    Hourly = false,
                    PartTime = false,
                    DuringOperation = new TimeSpan(10, 0, 0),
                    Coaching = true
                });

            var salary1P = CalculateSalary(data1P);

            Assert.IsTrue(20m == salary1A && 1190.0m == salary1B && 65 == salary1C && 1000 == salary1D && 5860 == salary1E && 770.0m == salary1H && 2225.0m == salary1F
                && 2000.0m == salary1I && 2035.0m == salary1K && 497.58333300m == salary1J && 4000.0m == salary1L && 4000.0m == salary1M && 20m == salary1N && 880m == salary1O && 1040 == salary1P);
        }

        //Постоянные сотрудники
        public void TestPermanent()
        {
            //22
            DataForCalcSalary data1A = new DataForCalcSalary();
            data1A.StatusWorkDoneForShift = "permanent";
            data1A.Dinner = true;
            data1A.StartWorkingShift = new TimeSpan(8, 0, 0);
            data1A.EndWorkingShift = new TimeSpan(16, 0, 0);
            data1A.OperationsWorkingShift.Add(new DataOperation()
            {
                Count = 100,
                PriceForOne = 0.2,
                CostPerHour = 70,
                Hourly = false,
                PartTime = false,
                DuringOperation = new TimeSpan(8, 0, 0)
            });
            var salary1A = CalculateSalary(data1A);


            // 1316
            DataForCalcSalary data1B = new DataForCalcSalary();
            data1B.StatusWorkDoneForShift = "permanent";
            data1B.Dinner = true;
            data1B.StartWorkingShift = new TimeSpan(8, 0, 0);
            data1B.EndWorkingShift = new TimeSpan(20, 0, 0);

            data1B.OperationsWorkingShift.Add(new DataOperation()
            {
                Count = 100,
                PriceForOne = 1.2,
                CostPerHour = 105,
                Hourly = true,
                PartTime = false,
                DuringOperation = new TimeSpan(12, 0, 0)
            });
            var salary1B = CalculateSalary(data1B);

            //2165
            DataForCalcSalary data1C = new DataForCalcSalary();
            data1C.StartWorkingShift = new TimeSpan(8, 0, 0);
            data1C.EndWorkingShift = new TimeSpan(15, 0, 0);
            data1C.Dinner = true;
            data1C.StatusWorkDoneForShift = "permanent";

            data1C.OperationsWorkingShift.Add(new DataOperation()
            {
                Count = 1000,
                PriceForOne = 2.0,
                CostPerHour = 75,
                Hourly = true,
                PartTime = false,
                DuringOperation = new TimeSpan(1, 0, 0)
            });
            var salary1C = CalculateSalary(data1C);

            //2200
            DataForCalcSalary data1I = new DataForCalcSalary();
            data1I.StartWorkingShift = new TimeSpan(20, 0, 0);
            data1I.EndWorkingShift = new TimeSpan(8, 0, 0);
            data1I.Dinner = true;
            data1I.StatusWorkDoneForShift = "permanent";

            data1I.OperationsWorkingShift.Add(
                new DataOperation()
                {
                    Count = 1000,
                    PriceForOne = 2.0,
                    CostPerHour = 75,
                    Hourly = false,
                    PartTime = false,
                    DuringOperation = new TimeSpan(1, 0, 0)
                });
            var salary1I = CalculateSalary(data1I);

            // 948.75
            DataForCalcSalary data1D = new DataForCalcSalary();
            data1D.StatusWorkDoneForShift = "permanent";
            data1D.StartWorkingShift = new TimeSpan(0, 0, 0);
            data1D.EndWorkingShift = new TimeSpan(0, 0, 1);
            data1D.Dinner = false;

            data1D.OperationsWorkingShift.Add(new DataOperation()
            {
                Count = 1000,
                PriceForOne = 1.0,
                CostPerHour = 75,
                Hourly = true,
                PartTime = false,
                DuringOperation = new TimeSpan(11, 20, 0)
            });
            var salary1D = CalculateSalary(data1D);

            // 6460
            DataForCalcSalary data1E = new DataForCalcSalary();
            data1E.StatusWorkDoneForShift = "permanent";
            data1E.StartWorkingShift = new TimeSpan(20, 0, 0);
            data1E.EndWorkingShift = new TimeSpan(20, 0, 0);
            data1E.Dinner = true;

            data1E.OperationsWorkingShift.Add(new DataOperation()
            {
                Count = 1000,
                PriceForOne = 2.0,
                CostPerHour = 70,
                Hourly = false,
                PartTime = true,
                DuringOperation = new TimeSpan(0, 0, 0)
            });

            //
            data1E.OperationsWorkingShift.Add(new DataOperation()
            {
                Count = 1000,
                PriceForOne = 2.0,
                CostPerHour = 75,
                Hourly = true,
                PartTime = true,
                DuringOperation = new TimeSpan(10, 0, 0)
            });

            var salary1E = CalculateSalary(data1E);

            //770 (по факту 652 но это < 770 за 11 часа т.к. был обед)
            DataForCalcSalary data1H = new DataForCalcSalary();
            data1H.StatusWorkDoneForShift = "permanent";
            data1H.StartWorkingShift = new TimeSpan(8, 0, 0);
            data1H.EndWorkingShift = new TimeSpan(20, 0, 0);
            data1H.Dinner = true;

            data1H.OperationsWorkingShift.Add(new DataOperation()
            {
                Count = 1,
                PriceForOne = 2.0,
                CostPerHour = 70,
                Hourly = false,
                PartTime = false,
                DuringOperation = new TimeSpan(0, 0, 0)
            });

            //
            data1H.OperationsWorkingShift.Add(new DataOperation()
            {
                Count = 100,
                PriceForOne = 2.0,
                CostPerHour = 75,
                Hourly = true,
                PartTime = false,
                DuringOperation = new TimeSpan(6, 0, 0)
            });

            //
            data1H.OperationsWorkingShift.Add(new DataOperation()
            {
                Count = 100,
                PriceForOne = 2.0,
                CostPerHour = 70,
                Hourly = false,
                PartTime = false,
                DuringOperation = new TimeSpan(6, 0, 0)
            });

            var salary1H = CalculateSalary(data1H);

            // 2447,5
            DataForCalcSalary data1F = new DataForCalcSalary();
            data1F.StatusWorkDoneForShift = "permanent";
            data1F.StartWorkingShift = new TimeSpan(20, 0, 0);
            data1F.EndWorkingShift = new TimeSpan(20, 0, 0);
            data1F.Dinner = false;

            data1F.OperationsWorkingShift.Add(new DataOperation()
            {
                Count = 100,
                PriceForOne = 2.0,
                CostPerHour = 70,
                Hourly = false,
                PartTime = true,
                DuringOperation = new TimeSpan(0, 0, 0)
            });

            //
            data1F.OperationsWorkingShift.Add(new DataOperation()
            {
                Count = 100,
                PriceForOne = 2.0,
                CostPerHour = 75,
                Hourly = true,
                PartTime = true,
                DuringOperation = new TimeSpan(10, 0, 0)
            });

            //
            data1F.OperationsWorkingShift.Add(new DataOperation()
            {
                Count = 100,
                PriceForOne = 2.0,
                CostPerHour = 70,
                Hourly = false,
                PartTime = false,
                DuringOperation = new TimeSpan(10, 0, 0)
            });

            //
            data1F.OperationsWorkingShift.Add(new DataOperation()
            {
                Count = 100,
                PriceForOne = 2.0,
                CostPerHour = 70,
                Hourly = false,
                PartTime = false,
                DuringOperation = new TimeSpan(10, 0, 0)
            });

            //
            data1F.OperationsWorkingShift.Add(new DataOperation()
            {
                Count = 100,
                PriceForOne = 2.0,
                CostPerHour = 70,
                Hourly = false,
                PartTime = false,
                DuringOperation = new TimeSpan(10, 0, 0)
            });

            //
            data1F.OperationsWorkingShift.Add(new DataOperation()
            {
                Count = 100,
                PriceForOne = 2.0,
                CostPerHour = 70,
                Hourly = false,
                PartTime = false,
                DuringOperation = new TimeSpan(10, 0, 0)
            });

            var salary1F = CalculateSalary(data1F);

            // 2238.5
            DataForCalcSalary data1K = new DataForCalcSalary();
            data1K.StatusWorkDoneForShift = "permanent";
            data1K.StartWorkingShift = new TimeSpan(20, 0, 0);
            data1K.EndWorkingShift = new TimeSpan(20, 0, 0);
            data1K.Dinner = false;

            data1K.OperationsWorkingShift.Add(new DataOperation()
            {
                Count = 1,
                PriceForOne = 2.0,
                CostPerHour = 70,
                Hourly = false,
                Coaching = true,
                PartTime = true,
                DuringOperation = new TimeSpan(2, 0, 0)
            });

            //
            data1K.OperationsWorkingShift.Add(new DataOperation()
            {
                Count = 100,
                PriceForOne = 2.0,
                CostPerHour = 75,
                Coaching = true,
                Hourly = true,
                PartTime = true,
                DuringOperation = new TimeSpan(10, 0, 0)
            });

            //
            data1K.OperationsWorkingShift.Add(new DataOperation()
            {
                Count = 100,
                PriceForOne = 2.0,
                CostPerHour = 70,
                Coaching = true,
                Hourly = false,
                PartTime = false,
                DuringOperation = new TimeSpan(10, 0, 0)
            });

            var salary1K = CalculateSalary(data1K);


            // 547.34
            DataForCalcSalary data1J = new DataForCalcSalary();
            data1J.StatusWorkDoneForShift = "permanent";
            data1J.StartWorkingShift = new TimeSpan(8, 0, 0);
            data1J.EndWorkingShift = new TimeSpan(21, 0, 0);
            data1J.Dinner = false;

            data1J.OperationsWorkingShift.Add(new DataOperation()
            {
                Count = 500,
                PriceForOne = 0.1925,
                CostPerHour = 70,
                Coaching = false,
                Hourly = false,
                PartTime = false,
                DuringOperation = new TimeSpan(0, 0, 0)
            });

            //
            data1J.OperationsWorkingShift.Add(new DataOperation()
            {
                Count = 500,
                PriceForOne = 0.102666666,
                CostPerHour = 70,
                Coaching = true,
                Hourly = false,
                PartTime = false,
                DuringOperation = new TimeSpan(0, 0, 0)
            });

            //
            data1J.OperationsWorkingShift.Add(new DataOperation()
            {
                Count = 2000,
                PriceForOne = 0.102666666,
                CostPerHour = 70,
                Coaching = true,
                Hourly = false,
                PartTime = false,
                DuringOperation = new TimeSpan(5, 0, 0)
            });

            var salary1J = CalculateSalary(data1J);

            // 4400 обед не учитывается, смене 2 операции и обе по шт.
            DataForCalcSalary data1L = new DataForCalcSalary();
            data1L.StatusWorkDoneForShift = "permanent";
            data1L.StartWorkingShift = new TimeSpan(20, 0, 0);
            data1L.EndWorkingShift = new TimeSpan(20, 0, 0);
            data1L.Dinner = true;

            data1L.OperationsWorkingShift.Add(new DataOperation()
            {
                Count = 1000,
                PriceForOne = 2.0,
                CostPerHour = 70,
                Hourly = false,
                PartTime = false,
                DuringOperation = new TimeSpan(0, 0, 0)
            });


            data1L.OperationsWorkingShift.Add(new DataOperation()
            {
                Count = 1000,
                PriceForOne = 2.0,
                CostPerHour = 75,
                Hourly = false,
                PartTime = false,
                DuringOperation = new TimeSpan(10, 0, 0)
            });

            var salary1L = CalculateSalary(data1L);

            // 4000 обед не учитывается, смене 2 операции и обе по шт.
            DataForCalcSalary data1M = new DataForCalcSalary();
            data1M.StatusWorkDoneForShift = "permanent";
            data1M.StartWorkingShift = new TimeSpan(20, 0, 0);
            data1M.EndWorkingShift = new TimeSpan(20, 0, 0);
            data1M.Dinner = false;

            data1M.OperationsWorkingShift.Add(new DataOperation()
            {
                Count = 1000,
                PriceForOne = 2.0,
                CostPerHour = 70,
                Hourly = false,
                PartTime = false,
                DuringOperation = new TimeSpan(0, 0, 0)
            });


            data1M.OperationsWorkingShift.Add(
                new DataOperation()
                {
                    Count = 1000,
                    PriceForOne = 2.0,
                    CostPerHour = 75,
                    Hourly = false,
                    PartTime = false,
                    DuringOperation = new TimeSpan(10, 0, 0)
                });

            var salary1M = CalculateSalary(data1M);

            // 6460
            DataForCalcSalary data1N = new DataForCalcSalary();
            data1N.StatusWorkDoneForShift = "permanent";
            data1N.StartWorkingShift = new TimeSpan(20, 0, 0);
            data1N.EndWorkingShift = new TimeSpan(20, 0, 0);
            data1N.Dinner = true;
            data1N.SpecialCostWordDoneForShift = 100;

            data1N.OperationsWorkingShift.Add(new DataOperation()
            {
                Count = 1,
                PriceForOne = 2.0,
                CostPerHour = 70,
                Hourly = false,
                PartTime = true,
                DuringOperation = new TimeSpan(1, 0, 0)
            });

            //
            data1N.OperationsWorkingShift.Add(new DataOperation()
            {
                Count = 1,
                PriceForOne = 2.0,
                CostPerHour = 75,
                Hourly = true,
                PartTime = false,
                DuringOperation = new TimeSpan(10, 0, 0)
            });

            var salary1N = CalculateSalary(data1N);

            Assert.IsTrue(22m == salary1A && 1316.0m == salary1B && 2165 == salary1C && 1100 == salary1D && 6460 == salary1E && 770.0m == salary1H && 2447.5m == salary1F
                && 2200.0m == salary1I && 2238.5m == salary1K && 547.34166630m == salary1J && 4400 == salary1M && 4400 == salary1M && 903.3m == salary1N);
        }
    }
}
