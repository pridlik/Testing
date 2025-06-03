using lab_6_5_sem_c_sharp;

namespace circle_tests
{
    [TestClass]
    public class circle_tests
    {
        private circle test_circle;
        [TestInitialize]
        public void test_initialize()
        {
            test_circle = new circle(10,12,7);
            
        }
        [TestMethod]
        public void sum_radius7_circle_8_result_radius15()
        {
            int sum_num = 8;
            circle expected_circle = new circle(10, 12, 15);
            test_circle = test_circle + sum_num;
            Assert.AreEqual(expected_circle, test_circle);
        }
        [TestMethod]
        public void sum_8_result_radius7_circle_radius15()
        {
            int sum_num = 8;
            circle expected_circle = new circle(10, 12, 15);

            test_circle = sum_num + test_circle;
            Assert.AreEqual(expected_circle, test_circle);
        }
        [TestMethod]
        public void sum_circle_10_12_7_circle_12_2_8_result_circle_11_7_15()
        {
            circle second_circle = new circle(12,2,8);
            circle expected_circle = new circle(11, 7, 15);
            test_circle = second_circle + test_circle;
            Assert.AreEqual(expected_circle, test_circle);
        }
        [TestMethod]
        public void Sdistance_circle_3_4_6_result_5()
        {
            circle test_circle = new circle(3, 4, 6);
            double expected = 5;
            double result = circle.Sdistance(test_circle);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void test_operator_increment_circle_10_12_7_result_circle_10_12_8()
        {
            circle expected_circle = new circle(10, 12, 8);
            test_circle++;
            Assert.AreEqual(expected_circle,test_circle);
        }
        [TestMethod]
        public void test_initialize_circle_result_circle_0_0_0()
        {
            circle test_circle = new circle();
            circle expected_circle = new circle(0, 0, 0);
            Assert.AreEqual(expected_circle, test_circle);
        }
        [TestMethod]
        public void test_initialize_circle_rad_5_circle_result_circle_0_0_5()
        {
            circle test_circle = new circle(5);
            circle expected_circle = new circle(0, 0, 5);
            Assert.AreEqual(expected_circle, test_circle);
        }
        [TestMethod]
        public void distance_error_rad_0_result_ex2()
        {
            test_circle = new circle(12, 7, 0);
            string expected_s = "Радиус окружности равен 0";
            double num;
            string reusult_s = "";
            try
            {
                num = test_circle.distance();
            }
            catch(Exception e2)
            {
                reusult_s = e2.Message;
            }
            Assert.AreEqual(expected_s, reusult_s);
        }
        [TestMethod]
        public void distance_error_coordx_0_coordy_0_result_ex2()
        {
            test_circle = new circle(0, 0, 12);
            string expected_s = "Окружность находится в начале координат";
            double num;
            string reusult_s = "";
            try
            {
                num = test_circle.distance();
            }
            catch (Exception e2)
            {
                reusult_s = e2.Message;
            }
            Assert.AreEqual(expected_s, reusult_s);
        }
        [TestMethod]
        public void convert_circle_10_12_7_to_string_10_12_7()
        {
            string expected_string = "10 12 7";
            string result_string = test_circle.ToString();
            Assert.AreEqual(expected_string,result_string);
        }
    }
}