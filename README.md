# SOLID-Principles

Simple examples of using the SOLID (or SDOLI) Principles in C# (.NET Core)


## Explanation

One does not adhere to each individual principle in isolation.

If you follow one principle, you most likely are also following the other principles.

For example, if you follow OCP, you most likely are also following SRP, and DIP.


## Requirement and Implementation

**Requirement:** Display order id with items. If quantity is greater than 100, render it in red.

![](print-order-details.png)

### 1.0 SRP-violation

The code for calculating the values for the report and the code for displaying the report 
are both placed in one area, which is the `ReportPresenter` class.
It makes this class look garbled and hard to maintain.

To solve this, we make use of the Single Responsibility Principle (SRP).

### 1.1 SRP

The code for calculating the values for the report are moved to a separate class named `ReportGenerator`.
Now, the `ReportPresenter` class is only responsible for displaying the report.

But there is a design flaw in the `ReportGenerator` class: It instantiates an `OrderRepository` directly.

``` csharp
public PrintableData GenerateReportData(Guid orderId)
{
    var orderRepository = new OrderRepository();
    var order = orderRepository.GetOrder(orderId);
    ...
}
```

This violates the design principle which states "depend on abstractions, not on concretions".

This problem is solved in Step #2, by applying the Dependency Inversion Principle (DIP).

### 2. DIP

``` csharp
private readonly IOrderRepository orderRepository;

public ReportGenerator(IOrderRepository orderRepository)
{
    this.orderRepository = orderRepository;
}

public PrintableData GenerateReportData(Guid orderId)
{
    var order = orderRepository.GetOrder(orderId);
    ...
}
```

### 3. OCP

We got a new requirement from our boss. 
He wants to be able to print the order details in a paper printer using a different format.

We could put the new code in the `ReportPresenter` class. 
But doing that is risky because we do not have existing automated tests to catch 
regression bugs that we might introduce if we change that class.

We can do something to make our code "open to extension, but closed to modification".

We can create a new interface (or ablstract class) named `IPresenter`.
Then we let `ReportPresenter` implement that interface.

Then we create a new class named `ReportPrinter` which also implements the `IPresenter` interface.
We put here our new code for the new requirement of printing the order details in a paper printer.

...

### 4.0 LSP-violation



## References

[**"Uncle Bob Martin: SOLID, this time with feeling."**](https://www.hanselman.com/blog/HanselminutesPodcast145SOLIDPrinciplesWithUncleBobRobertCMartin.aspx)

 - In this podcast Sctott Hanselman asks Uncle Bob Martin to sort the SOLID principles by importance. He sorted it as SDOLI.

[**"The Single Responsibility and Open/Closed Principle are the Same"**](https://michaelfeathers.typepad.com/michael_feathers_blog/2013/07/the-single-responsibility-principle-leads-to-good-openclosed-characteristics.html) by Michael Feathers

**Chapter 8 of the book "Clean Architecture" by Robert C. Martin**

> A THOUGHT EXPERIMENT
> 
> Imagine, for a moment, that we have a system that displays a financial summary on a web page. The data on the page is scrollable, and negative numbers are rendered in red.
> 
> Now imagine that the stakeholders ask that this same information be produced into a report to be printed on a black-and-white printer. The report should be properly paginated, with appropriate page headers, page footers, and column labels. Negative numbers should be surrounded by parentheses.
> 
> Clearly there will be some new code to write. But how much old code will have to change?
> 
> A good software architecture would reduce the amount of changed code to the barest minimum. Ideally, zero.
> 
> How? By properly separating the things that change for different reasons (The SRP), and then organizing the dependencies between those things properly (The DIP).



