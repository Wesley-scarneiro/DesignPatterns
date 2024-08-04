namespace DesignPatterns.TemplateMethod
{
    // Classe base
    // Aplica a inversão de controle usando o padrão Template Method
    public abstract class Employee
    {
        public double Salary { get; private set; }

        public Employee(double salary)
        {
            Salary = salary;
        }

        public abstract double CalcSocialSecurity();
        public abstract double CalcHealthPlan();
        public abstract double CalcOtherDiscounts();

        // Chama as implementações das subclasses
        public double CalcNetSalary()
        {
            var discounts = CalcSocialSecurity() + CalcHealthPlan() + CalcOtherDiscounts();
            return Salary - discounts;
        }
    }

    // Funcionário público
    // Implementa os métodos abstratos de Employee
    public class CivilServant : Employee
    {
        public CivilServant(double salary) : base(salary) { }

        public override double CalcHealthPlan()
        {
            // Algum cálculo
            var result = 0;
            return result;
        }

        public override double CalcOtherDiscounts()
        {
            // Algum cálculo
            var result = 0;
            return result;
        }

        public override double CalcSocialSecurity()
        {
            // Algum cálculo
            var result = 0;
            return result;
        }
    }

    // Funcionário CLT
    // Implementa os métodos abstratos de Employee
    public class EmployeeCLT : Employee
    {
        public EmployeeCLT(double salary) : base(salary) { }

        public override double CalcHealthPlan()
        {
            // Algum cálculo
            var result = 0;
            return result;
        }

        public override double CalcOtherDiscounts()
        {
            // Algum cálculo
            var result = 0;
            return result;
        }

        public override double CalcSocialSecurity()
        {
            // Algum cálculo
            var result = 0;
            return result;
        }
    }

    public class ClientCode
    {
        public static void Consumer()
        {
            // Salário líquido de funcionário público
            var civilServent = new CivilServant(5000);
            var salary1 = civilServent.CalcNetSalary();

            // Salário líquido de funcionário CLT
            var employeeClt = new EmployeeCLT(5000);
            var salary2 = civilServent.CalcNetSalary();
        }
    }
}
