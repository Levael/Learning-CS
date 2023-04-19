namespace test-project {
    public class Bottom {
        virtual public void foo() {
            Console.WriteLine("Bottom");
        }
    }

    public class Middle : Bottom {
        override public void foo() {
            base.foo();
            Console.WriteLine("Middle");
        }
    }

    public class Top : Middle {
        override public void foo() {
            base.foo();
            Console.WriteLine("Top");
        }
    }
}
