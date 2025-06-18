SELECT Email --To See Before
FROM Employees
WHERE Email IS NOT NULL;

UPDATE Employees
SET Email = 
    SUBSTRING(Email, 1, POSITION('@' , Email)) +  -- User part
    'company' + -- New host
    SUBSTRING(Email FROM POSITION('.' , Email)) -- Domain part
WHERE Email IS NOT NULL;

SELECT Email -- To Verify/See Results
FROM Employees
WHERE Email IS NOT NULL;

RoLLBACK; -- Rollback to undo changes if needed
--commit; -- Commit changes if everything is correct


