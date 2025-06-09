# Please attempt to complete question (1) first. If you are happy with your solution, attempt question (2).
# Do not worry if you don't complete both questions. Please submit your code however far you get with the solutions *(Please ensure it compiles first)*.

# Make a note of potential code improvements that could be made so that this can be discussed.

# Question (1)

A valid star fighter looks like:
(-O-)
All other characters are junk, and are not part of a star fighter.

We can build star fighters from their individual parts:
1 x '('
2 x '-'
1 x 'O'
1 x ')'
You receive a string of characters. Create a collection of the complete star fighters which could be built from the input parts.

input: `(-O-)|&*-(-O-)(-O-)=+=.`
result = 3 star fighters  (3 already-complete star fighters)

input: `(-O-|)&*)-O-(`
result = 2  star fighters (enough parts to make 2 star fighers)

input: `((--O`
result = 0  star fighters (Not enough parts to even make one star figher)

method signature:
``` csharp
public IList<StarFighter> BuildStarFighters(string parts)
```

----

# Question (2)

 A new type of star fighter is available. For this exercise they are now worth points. 

TYPE1 = `(-O-)` = 15 points   
1 x '('
2 x '-'
1 x 'O'
1 x ')'

TYPE2 = `[--O--]` = 20 points
1 x '['
4 x '-'
1 x 'O'
1 x ']'

You receive a string of characters. The goal is to maximise the number of points you can make, by producing complete star fighters from their parts

input: `(-O-)[--O--]`
result = 35 points  (1 x TYPE1, 1xTYPE2 )

input: `------((()))OOO[]`
result = 45 points (3 x TYPE1)

input: `((--O-[]`
result = 0 points (Not enough parts to even make one star fighter of either kind)

method signature:
``` csharp
public IList<StarFighter> BuildBestStarFighters(string parts)
```
