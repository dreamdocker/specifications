One Domain-Driven-Design solution to the problem of where to place querying, sorting, and paging logic is to use a Specification. 

The Specification design pattern describes a query in an object. So to encapsulate a paged query that searches for some products, one might create a PagedProduct specification which would take in any necessary parameters (pageSize, pageNumber, filter). Then one of your repository methods (usually a List() overload) would accept an ISpecification and would be able to produce the expected result given the specification. There are several benefits to this approach. 

The specification has a name (as opposed to just a bunch of LINQ expressions) that you can reason about and discuss. It can be unit tested in isolation to ensure correctness. And it can easily be reused if you need the same behavior (say on an MVC View action and a Web API action, as well as in various services). Further, a specification can also be used to describe the shape of the data to be returned, so that queries can return just the data they required. 