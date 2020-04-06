# Problem 1 – Jedi Meditation

A longtimeago, in a galaxyfar, faraway...

AllJedimustmeditate. Yet, whenthe Jediare at their temple, they cannot mediateat the same time, becausethe temple will overload itself with too much forceandan implosion will occur. Thereis a **strict**** order **for meditations: JediMastersmediate** first **,** then **Jedi Knights, and** lastly –** the Padawans.

Given thesequenceofJedi:

{Jedi Type}{Jedi Level}

p1 k1 m2 m1 k2 p2

they will meditate in the following order:

m2 m1 k1 k2 p1 p2

**m**  means a Jedi Master,  **k**  is a Jedi Knight, and  **p**  is a Padawan.

Toshkoand Slavare padawans. Theywant to haveas much timewith the Force as they can. So theyalways try to mediate **before** Jedi Masters, **until** Jedi Master Yoda shows up and moves them **after** Jedi Knightsand **before** Jedi Padawans. Given that  they do not want to waitmeaninglesslyfor meditation, you need to help themsolve in which orderall Jedi will mediate. There can be multiple yodas, but the number identifiers (such as m **2** are unique**).**

### Input

- On the first line, you will find the number N – the count of the input lines.
- On the next N lines you will receive sequences with Jedis, separated by a **single space** , waiting for meditation
  - **m**  meansJedi master
  - **k**  means Jedi knight
  - **p**  means Jedi padawan
  - **t** means Toshko the padawan
  - **s** means Slav the padawan
  - **y** means Master Yoda

### Output

- The output consists of a single line.
- You must print the sequence of jedis, ready for meditation in the correct order, and in the following format:
  - Print each jedis type and level
  - Differentjedis are separated by a **single**** space**
  - Master Yoda must **NOT** be printed.

### Constraints

- 0 \&lt; N \&lt; 100 000
- All inputs will be **lowercase** characters

| **Input** | **Output** |
| --- | --- |
| 2m1 k1 p1 t1 s1m2 p2 | t1 s1 m1 m2 k1 p1 p2 |



| **Input** | **Output** |
| --- | --- |
| 1p4 p2 p3 m1 k2 p1 k1 s1 t1 y1 | m1 k2 k1 s1 t1 p4 p2 p3 p1  |