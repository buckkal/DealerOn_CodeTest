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
    
    I decided to go with option 1 first. Since I have a linux machine, I can only use VSCode. I also chose to perform this task with .Net. In order to get a UI page to appear, I downloaded the extension 'open in browser'. I then right-clicked on the html file and select 'open in other browsers' (can do 'open in default broswer') before selecting firefox.

    I was very interested in each one, and I haven't fully coded in a long time. So, I decided to do Option 2. 

    Since I still have time, I added Option 3 into the mix.

Submission:
 - Email link to a public Github repo to code@dealeron.com
 - Don't include .exe, .msi, .dll, or other binary files
 - 4-8 Total hours 