# dotnet-webapi-ddd
C# WebAPI implemented with .NET and DDD concepts.

# help needed
I am trying to find a way to make a generic handler that could handle all the models and database operations, I am doing some researchs but did not found anything workable yet. All implementations of the mediator pattern that I found have one handler for each model.

#. objective
- learn mediator pattern and c# for team project called TripleX at Stefanini

# to implement on handlers
- http://wiki.c2.com/?NeedlessRepetition
- http://wiki.c2.com/?OnceAndOnlyOnce
- http://wiki.c2.com/?CodeHarvesting

Abut the Feature layer, especially the handlers, that will be refactored to abstract classes as an excercise

- "Over time, I've learned that trying to get an abstraction right the first time is like premature optimization--until you can make decisions based on real usage patterns, your early guesses are liable to be off. Allowing a bit of CopyAndPasteProgramming can add interesting diversity to the gene pool, resulting in a better basis for selecting out winning abstractions."

- Then, in DontRepeatYourself, RalphJohnson wrote: ... "it is often better to wait til you have several examples of the duplication so you can better see how to eliminate it."

# trying to avoid
- https://wiki.c2.com/?PrematureGeneralization
