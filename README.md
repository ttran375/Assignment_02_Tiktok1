# Programming II

Maximum points for this work is 50 marks.

TikTok is a video-sharing social networking service owned by ByteDance,
a Chinese company founded in 2012 by Zhang Yiming. It is used to create
short dance, lip-sync, comedy and talent videos. … As of 2018, TikTok
has been made available in over 150 markets, and in 75 languages. TikTok
was downloaded more than 104 million times on Apple's App store during
the full first half of 2018, according to data provided to CNBC by
Sensor Tower. It surpassed Facebook, YouTube and Instagram to become the
world's most downloaded iOS app (https://en.wikipedia.org/wiki/TikTok).

This assignment attempts to model this social phenomenon. It involves an
enum and two main classes: Audience, TikTok and TiktokManager. You will
load a set of tikoks from a local file into a List collection. You will
perform some simple queries on this collection.

The Tikok and the TikokManager classes must be in separate files and
must not be in the Program.cs file. The Audience enum may be implemented
in the Tiktok.cs file.

## The Audience Enum 4 Marks

This enum specifies the intended audience for this tiktok. It consists
of three constants as shown in the table below:

<table>
<colgroup>
<col style="width: 100%" />
</colgroup>
<thead>
<tr class="header">
<th><p><strong>Audience</strong></p>
<p><strong>Enum</strong></p></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><strong>Constants</strong></td>
</tr>
<tr class="even">
<td><blockquote>
<p><strong>World</strong></p>
<p><strong>Group</strong></p>
<p><strong>Special</strong></p>
</blockquote></td>
</tr>
</tbody>
</table>

## The TikTok Class 23 Marks

The TikTok class consist of ten members that include two static ones
(the members decorated with the **\$** symbol). You will implement this
and all of the classes in Visual Studio. A short description of the
class members is given below:

<table>
<colgroup>
<col style="width: 100%" />
</colgroup>
<thead>
<tr class="header">
<th><p><strong>TikTok</strong></p>
<p><strong>Class</strong></p></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><strong>Fields</strong></td>
</tr>
<tr class="even">
<td><blockquote>
<p>-$ _ID : int</p>
</blockquote></td>
</tr>
<tr class="odd">
<td><strong>Properties</strong></td>
</tr>
<tr class="even">
<td><blockquote>
<p>+ «property setter absent» Originator : string</p>
<p>+ «property setter absent» Length : int</p>
<p>+ «property setter absent» HashTag : string</p>
<p>+ «property setter absent» Audience : Audience</p>
<p>+ «property setter absent» Id : string</p>
</blockquote></td>
</tr>
<tr class="odd">
<td><strong>Methods</strong></td>
</tr>
<tr class="even">
<td><blockquote>
<p>+ «constructor»TikTok(</p>
<p>originator : string,</p>
<p>length : int,</p>
<p>hashTag : string,</p>
<p>audience : Audience)</p>
<p>+ «constructor»Tikok(</p>
<p>id : string,</p>
<p>originator : string,</p>
<p>length : string,</p>
<p>hashTag : string,</p>
<p>audience : string)</p>
<p>+ ToString() : string</p>
<p>+$ Parse(line : string) : TikTok</p>
</blockquote></td>
</tr>
</tbody>
</table>

The **\$** symbol is used to denote that this member belongs to the type
rather than a specific object and you must use the type to access that
member.

### Fields:

1.  **\_ID** – this private field is a class variable, it represents the
    number to be used in setting the id of this item.

### Properties:

All of the properties are readonly and are self-explanatory.

1.  **Originator** – this property is a string representing the
    originator of this tikok. The getter is public and the setter is
    absent.

2.  **Length** – this property is an int representing the length in
    second recipient of this tikok. The getter is public and the setter
    is absent.

3.  **HashTag** – this property is a string representing the hashtag of
    this tikok. The getter is public and the setter is absent.

4.  **Audience** – this property is a string representing the
    distribution of this tikok. The getter is public and the setter is
    absent.

5.  **Id** – this property is a string representing the id of this
    tikok. The getter is public and the setter is absent. This is used
    to uniquely identify a tikok.

### Methods:

1.  **public TikTok(string originator, int length, string hashTag,**
    Audience **audience) <span class="mark"></span>**– This public
    constructor takes four string parameters. This constructor does the
    following:

This is an example of constructor overloading

1.  Assigns the arguments to the appropriate properties.

2.  Sets the **Id** property using the class variable **\_ID**.

3.  After the **Id** property is set, the **\_ID** is then incremented
    so that the next assignment will be unique. (see description of Id
    above)

<!-- -->

2.  **private TikTok(string id, string originator, int length, string
    hashTag,** Audience **audience) <span class="mark"></span>**– This
    public constructor takes five string parameters. This is called by
    the **static TikTok Parse(string)** method. This constructor does
    the following:

    1.  Assigns the arguments to the appropriate properties.

### Methods:

1.  **<span class="mark">public override string ToString()</span>** –
    This method overrides the same method of the Object class. It does
    not take any parameter but return a string representation of itself.
    You decide on the format for the output.

2.  **public static TikTok Parse(string line)** – This is a public class
    method that takes a string argument and returns a TikTok object. It
    is used to create a TikTok object when loading the TikToks from a
    file. The argument represents a single line of input read from the
    file. This method does the following:

    1.  Uses the method of the string class is to chunk the input into
        four strings. The default delimiter for the **Split()** method
        is a space, however in this case the delimiter should be a tab.
        To specify an argument for the <span class="mark">Split()</span>
        method use the following code:
        **<span class="mark">Split('\t');</span>**

    2.  Invokes the five arguments constructor. Because all the
        arguments are string, it is easy to inter-change the order. You
        need to examine the text file to make sure that you are sending
        the arguments to the constructor in the required order.

    3.  Return the result of the above invocation

## The TikTokManager Class 21 Marks

This static class consist of five static members. You will also
implement this in Visual Studio. A short description of the class
members is given below:

<table>
<colgroup>
<col style="width: 100%" />
</colgroup>
<thead>
<tr class="header">
<th><p><strong>TikTokManager</strong></p>
<p>Static Class</p></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><strong>Fields</strong></td>
</tr>
<tr class="even">
<td><blockquote>
<p>-$ TIKTOKS : List&lt;TikTok&gt;</p>
<p>-$ FILENAME : string</p>
</blockquote></td>
</tr>
<tr class="odd">
<td><strong>Methods</strong></td>
</tr>
<tr class="even">
<td><blockquote>
<p>$ TikTokManager()</p>
<p>+$ Initialize() : void</p>
<p>+$ Show() : void</p>
<p>+$ Show(hashtag : string) : void</p>
<p>+$ Show(length : int) : void</p>
<p>+$ Show(audience : Audience) : void</p>
</blockquote></td>
</tr>
</tbody>
</table>

**ALL MEMBERS ARE STATIC!**

### Fields:

1.  **TIKTOKS** – this private field is a class variable; it is a
    collection of all the tiktoks in the system. It is initialized and
    populated in the static constructor.

2.  **FILENAME** – this private field is a class variable; it represents
    the name of the file that contains all the tiktoks. It is used in
    the static constructor to read in the tiktoks. You will have to set
    this to the name of file that has the information about the tiktoks.

A static constructor does not take any arguments, nor does it require
any accessibility modifier. Infact specifying one will raise a compiler
error

It is called before any member is accessed and never ever again.

### Methods:

1.  **static TikTokManager()** – This is the static constructor. It does
    not require any parameter. This constructor does the following:

    1.  Initialize the **TIKTOKS** field to a new list of tiktok

    2.  Opens the file specified by the filename field for reading

    3.  Using a looping structure it does the following:

        1.  Reads one line from the file.

        2.  Passes this line to the static **Parse()** method of the
            **<span class="mark">TikTok</span>** class to create a
            tiktok object.

        3.  The resulting object is added to the tiktok collection.

        4.  This is repeated until the input from the file is empty
            (**<span class="mark">null</span>**).

2.  **public static void Initialize()** – This class method it used to
    facilitate the development of this project. It will not be used in
    the production code, just while developing. This method does the
    following:

This will be used to test your code in the event you cannot figure out
the file reading part.

1.  Assigns the TIKOKS field

2.  Creates about 5 tiktoks objects and add them to the tiktok
    collection.

<!-- -->

3.  **public static void Show()** – This is a public class method that
    does not take any argument that does not return a value. It displays
    all the tiktoks in the collection.

This is good example of method overloading, i.e. methods with the same
name.

4.  **public static void Show(<span class="mark">string tag</span>)** –
    This is a public class method that takes a string argument that does
    not return a value. It displays all the tiktoks with hashTag
    matching the argument. This comparison must be case in-sensitive.

5.  **public static void Show(<span class="mark">int</span> length)** –
    This is a public class method that takes an int argument that does
    not return a value. It displays all the tiktoks with length greater
    than the argument.

6.  **public static void Show(**Audience **audience)** – This is a
    public class method that takes an int argument that does not return
    a value. It displays all the tiktoks with audience matching the
    argument.

## Testing 2 Marks

In your test harness (the Main() method in the Program Class), write the
code to test all the methods of the TikTokManager class including the
**Initialize()** method.
