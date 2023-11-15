# saberin-coding-challenge-submission

TIME TAKEN: 
roughly 40 minutes (not counting time to download/update tools).



CHANGES MADE:

Add an alert if an Email or Address was typed, but not added to the list, in New/Edit
Contact when saving.

Switch to a datepicker for the Date of Birth input and a dropdown for Title in New/Edit
Contact.

Add error handling to the controller methods (i.e. try/catch block).




NOT LISTED AS TASK TO DO BUT ADDED ANYWAYS:

Added in a date range (1900 to 2024) for date picker.

Added in protection that prevents an incomplete address or email from being added. Pops up an alert to inform you that the data provided isn't filled out properly when pressing add button. For email it uses the regex that was provided to detect an incorrect email, for address it checks to make sure all boxes are filled, street1 and street2 are linked such that as long as one of them is filled, it counts both of them as filled as not everyone lives on two different streets.
