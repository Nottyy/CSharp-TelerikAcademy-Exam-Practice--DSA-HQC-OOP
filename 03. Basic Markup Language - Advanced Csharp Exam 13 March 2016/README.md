# Problem 3 – Basic Mark-up Language

HTML is old and clumsy so a group of highly motivated Softuni students decided to create a new language for the web. It&#39;s basically the same in terms of clumsiness, but supports several revolutionary tags:

- **Inverse –** transforms its content&#39;s lowercase letters to uppercase and vice-versa.
  - \&lt;inverse content=&quot; **HelloWorlD**&quot;/\&gt; outputs **hELLOwORLd**
- **Reverse –** reverses its content
  - **\&lt;** reverse content=&quot; **helloworld**&quot;/\&gt; outputs **dlrowolleh**
- **Repeat –** repeats its content a specified amount of times
  - **\&lt;** repeat value=&quot; **2**&quot; content=&quot; **helloworld**&quot;/\&gt; outputs **helloworldhelloworld**
- **Stop –** \&lt;stop/\&gt; - marks the end of the **BML** file.

Your task is to write a program that correctly parses all currently supported BML tags and outputs the result to the console.

You should **not** output empty lines. For the content tag to be considered non-empty, it must contain **at least one character**.

### Input

- Until the **stop** tag is reached you receive **one** basic mark-up language tag per line
- There are **no invalid** tags or attributes. There may be whitespace **anywhere** in the input

### Output

- Print the correctly formatted output to the console according to the above described rules.
- Each line must have a number, starting from 1, in format &quot;\&lt;number\&gt;. \&lt;output\&gt;&quot;
- The \&lt;repeat/\&gt; tag outputs each string on a new line

### Constraints

- There are no more than 15 lines of input
- The **content** length is in range [0 … 50]. It will not contain double quotes &#39; &quot; &#39;
- The **value** attribute is in range [0 … 10]
- Allowed time/memory: 100ms/16MB

| **Input** | **Output** |
| --- | --- |
| \&lt;inverse content=&quot;HelloWorlD&quot;/\&gt; **\&lt;** reverse content=&quot;helloworld&quot; **/\&gt;**** \&lt; **reverse content=&quot;helloworld&quot;** /\&gt; ****\&lt;** repeat value=&quot;2&quot; content=&quot;helloworld&quot;/\&gt;\&lt;stop/\&gt; | 1. hELLOwORLd2. dlrowolleh3. dlrowolleh4. helloworld5. helloworld |



| **Input** | **Output** |
| --- | --- |
| **\&lt;** repeat value=&quot;2&quot; content=&quot;12345&quot;/\&gt; **\&lt;** repeat value=&quot;5&quot; content=&quot;12346&quot;/\&gt;\&lt;stop/\&gt; | 1. 123452. 123453. 123464. 123465. 123466. 123467. 12346 |