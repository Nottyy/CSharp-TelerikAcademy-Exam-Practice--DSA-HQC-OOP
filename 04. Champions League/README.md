# Problem 4 – Champion&#39;s League

The Champion&#39;s League is well under way and their team needs a person who can aggregate some data for them. Actually, that person is you. The data you receive will be in format:

**\&lt;team1\&gt; | \&lt;team2\&gt; | \&lt;team1 goals\&gt;:\&lt;team2 goals\&gt; | \&lt;team2 goals\&gt;:\&lt;team1 goals\&gt;**

For example: **Barcelona | Real Madrid | 2:1 | 3:2**. In that case, **Barcelona** have scored 4 goals total, **Real**** Madrid **have also scored 4 goals, but** Barcelona** is the overall winner because they have more goals on away soil. For each team, you need to keep the names of all teams they have played against. You also have to count the total wins.

There will be **no** matches with a score such as **2:2 | 2:2** where the winner must be decided by a penalty shootout. All pairs will be **unique**.

### Input

- You will receive several lines in the above described format. There is no redundant whitespace.
- The input ends with the command &#39; **stop**&#39;
- There is no invalid input.

### Output

- For each team print information in format:

**\&lt;team name\&gt;**

**- Wins: \&lt;total wins\&gt;**

**- Opponents: \&lt;opponent\_1, opponent\_2, … opponent\_N\&gt;**

- The teams must be ordered by total wins in descending order. If two teams have the same number of wins, keep in alphabetical order by team name.
- The opponents must be printed in alphabetical order.

### Constraints

- There are no more than 50 lines of input.
- The team names will consist of several words containing only English alphabet letters.
- The goals are integers in range [0 … 10].
- Allowed time/memory: 100ms/16MB

| **Input** | **Output** |
| --- | --- |
| Real Madrid | Barcelona | 0:0 | 1:1Barcelona | Arsenal | 2:0 | 0:2Liverpool | Manchester United | 2:0 | 0:0Bayern Munich | Juventus | 2:1 | 3:2stop | Barcelona- Wins: 1- Opponents: Arsenal, Real MadridBayern Munich- Wins: 1- Opponents: JuventusLiverpool- Wins: 1- Opponents: Manchester UnitedReal Madrid- Wins: 1- Opponents: BarcelonaArsenal- Wins: 0- Opponents: BarcelonaJuventus- Wins: 0- Opponents: Bayern MunichManchester United- Wins: 0- Opponents: Liverpool  |