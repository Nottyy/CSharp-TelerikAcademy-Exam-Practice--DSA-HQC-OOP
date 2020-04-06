# Problem 2 – Monopoly

Monopoly is such a fun game but you&#39;ve always been looking for something more. Besides, you want it to be fun even in single player mode. So you came up with a really nice idea which needs to be tested.

The rules are quite simple – there is a rectangular game field in which the **player** starts with 50 **money** at the **top**** left **corner. He** always** moves in the following way:

                        If he is moving **right** , he follows the row to the **last** column. Then he gets to the last column

                        in the row **next** row and starts **moving** left until he reaches the **first** column. The pattern

                        **repeats** to the end of the game field.

He moves one step at a time. On his way down, he will encounter one of the following objects:

- **H (hotel)** – the player spends **all** his money to buy the hotel. He then gets **10 money per turn** for it. A new hotel contributes to the income from the turn it is bought.
- **J (Jail)** – the player **cannot** move for **two** turns
- **F (Free)** – nothing happens here, the game just advances with one step
- **S (Shop)** – the player has to spend money equal to the **product** of the current **row** and **column** number (assume the first row/col is at position 1). If he doesn&#39;t have enough money, he spends all that he has.

For each of the objects except **F** you need to print a corresponding message to the console. At the end of the output, print the **total** turns done in the game and the **final** amount of money. Consider a **turn** to be an **iteration** of the game loop. **Note** that **contrary** to logic, a player can buy a hotel for 0 money.

### Input

- On the first line of input you receive integers **R** and **C** – the dimensions of the field
- On the next **R** lines – you are given a string with length **C** containing only one of the valid objects ( **H, J, F, S** )

### Output

- On the first several lines print a message that describes what happened to the player:
  - **oo** Buys a hotel – { **Bought a hotel for \&lt;money\&gt;. Total hotels: \&lt;hotels\&gt;.** }
  - **oo** Goes to jail – { **Gone to jail at turn \&lt;turn\&gt;.** }
  - **oo** Enters to shop – { **Spent \&lt;money\&gt; at the shop.** }
- On the last two lines after the player has reached the last cell:
  - **oo** { **Turns \&lt;turns\&gt;** }
  - **oo** { **Money \&lt;money\&gt;** }

### Constraints

- 1 ≤ R,C ≤ 10
- Time/memory allowed: 100ms/16MB

| **Input** | **Output** |
| --- | --- |
| 4 4HHHFFFFFSFFFFFFF | Bought a hotel for 50. Total hotels: 1.Bought a hotel for 10. Total hotels: 2.Bought a hotel for 20. Total hotels: 3.Spent 3 money at the shop.Turns 16Money 417 |







| **Input** | **Output** |
| --- | --- |
| 1 3HJF | Bought a hotel for 50. Total hotels: 1.Gone to jail at turn 1.Turns 5Money 50 |

| **Input** | **Output** |
| --- | --- |
| 2 4FFFFSFFH  | Bought a hotel for 50. Total hotels: 1.Spent 2 money at the shop.Turns 8Money 38 |