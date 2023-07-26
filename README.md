DealerOn - Code Test - Kaleb Buck

Coding Languages Used:
 - .Net Core/Framework

Steps to do:
 - Pick 1 out of 3 options
 - Code the project
 - Include a brief explanation of design and assumptions
 - Unit Tests are a Plus

Notes:
 - Avoid single-file submissions
 - Allow custom input
 - Have code have Readability

3 Options:

    1 - Mars Rovers:
        - Simple 2D-coordinate grid is mapped to a plateau (X,Y)
        - X = East, Y = North, Origin = (0,0)
        - (0,1) is directly north of (0,0)
        - (1,1) is directly east of (1,1)
        - Z = N E S W (where the rover is facing at a point)
        - Instruction Letters: 
            - L (turn left 90 degrees)
            - R (turn right 90 degrees)
            - M (move forward one point)
        - One cannot move until the rover moving finishes
        
        Test Input:
            5 5
            1 2 N
            LMLMLMLMM
            3 3 E
            MMRMMRMRRM

        Expected Output:
            1 3 N
            5 1 E

    2 - Sales Tax:
        - Create receipt from shopping cart
        - Sales tax on all items: 10% 
            - (exception: books, food, & medical)
        - Import tax applies and addes to sales tax: 5%
        - For sales tax, round up to nearest 5 cents

        Test Input 1:
            1 Book at 12.49
            1 Book at 12.49
            1 Music CD at 14.99
            1 Chocolate Bar at 0.85

        Expected Output 1:
            Book: 24.98 (2 @ 12.49)
            Music CD: 16.49
            Chocolate Bar: 0.85
            Sales Taxes: 1.50
            Total: 42.32

        Test Input 2:
            1 Imported box of chocolates at 10.00
            1 Imported bottle of perfume at 47.50

        Expected Output 2:
            Imported box of chocolates: 10.50
            Imported bottle of perfume: 54.65
            Sales Taxes: 7.65
            Total: 65.15

    3 - Trains:
        - Provide route information to customers
            - Route distance
            - Number of unique routes between two towns

        Calculate the following with inputs provided:
            1. Distance of route A-B-C
            2. Distance of route A-D
            3. Distance of route A-D-C
            4. Distance of route A-E-B-C-D
            5. Distance of route A-E-D
            6. # of trips, start with C, end with C, 3 max stops
                EX: C-D-C (2 stops), C-E-B-C (3 stops)
            7. # of trips, start with A, end with C, 4 max stops
                EX: A to C (via B,C,D); A to C (via D,C,D)
                    A to C (via (D,E,B))
            8. shortest route len from A to C
            9. shortest route from B to B
            10. # of diff routes from C to C, distance < 30
                EX: CDC, CEBC, CEBCDC, CDCEBC, CDEBC, CEBCEBC,
                    CEBCEBCEBC

Design Explanation:
    
    I decided to go with option 1 first. Since I have a linux machine, I can only use VSCode. 
    I was able to download the .Net 6.0 version onto the machine and use 'dotnet run' and 
    'dotnet build'. This took me a couple hours to figure out because I did try to see if I 
    could add a GUI first before deciding to utilize the terminal first. I made sure to aim 
    for future development within this project. An example of this can be seen in Program.cs 
    where I call the rover project and allow for the sales tax and train to be added later.

    I ran into another issue, where when I ran 'dotnet run' on the app folder, this error 
    would appear:
        System.TypeInitializationException: The type initializer for 'Microsoft.DotNet.Cli.
        Parser' threw an exception.
        ---> System.TypeInitializationException: The type initializer for 'Microsoft.DotNet.
        Cli.AddCommandParser' threw an exception.
        ---> System.IO.FileNotFoundException: Unable to find the specified file.
        at Interop.Sys.GetCwdHelper(Byte* ptr, Int32 bufferSize)
        at Interop.Sys.GetCwd()
        at System.IO.Directory.GetCurrentDirectory()
        at Microsoft.DotNet.Cli.CommonOptions.DefaultToCurrentDirectory[T](Argument`1 arg)
        at Microsoft.DotNet.Cli.AddCommandParser..cctor()
        --- End of inner exception stack trace ---
        at Microsoft.DotNet.Cli.AddCommandParser.GetCommand()
        at Microsoft.DotNet.Cli.Parser..cctor()
        --- End of inner exception stack trace ---
        at Microsoft.DotNet.Cli.Program.ProcessArgs(String[] args, TimeSpan startupTime, 
        ITelemetry telemetryClient)
        at Microsoft.DotNet.Cli.Program.Main(String[] args)
    I didn't really know what happened, so, I created another folder 'app2' after trying to 
    see if it was an issue with static methods. Once I did this, it worked just fine. However, 
    I realized where the issue was occuring. It gets screwed over when I create a branch and 
    run a Pull Request. Whether one merges or squashes, it does not help. So, I finally 
    created app3 on the main branch.

    When running the program, please use app3 and run 'dotnet run' in the terminal before 
    selecting the options provided. If you choose to upload a file, I have the input located 
    in DealerOn_CodeTest -> files. So, in order to find that location, you should put in 'home/
    buck/Projects/DealerOn_CodeTest/app3/files/Input1.txt' or where ever the DealerOn_CodeTest 
    repo has been cloned to.

    I was working on this too long because of the issues described above, so, I decided to 
    leave it at using the terminal instead of adding GUI. I also didn't get to unit tests 
    which would take me longer to do since the experience I have had with Unit Tests have been 
    with Angular, EmberJS, and NestJS.

    If I were to work on the GUI, I would have the user input the grid via a couple number 
    dropdowns. Then, I would utilize a panel where one can add and delete sections. In each 
    section, one would be able to put in the position of the rover via dropdowns and the 
    instructions in a string format. Finally, once it would be submitted, it would get saved 
    into a file and utilize the ReadFile that we already have in place or it would utilize the 
    RoverInterface/RoverData to then print out the results.


Submission:
 - Email link to a public Github repo to code@dealeron.com
 - Don't include .exe, .msi, .dll, or other binary files
 - 4-8 Total hours 