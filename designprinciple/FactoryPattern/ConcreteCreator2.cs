using RefactoringGuru.DesignPatterns.FactoryMethod.Conceptual;

class ConcreteCreator2 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct2();
        }
    }