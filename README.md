Hi!

I am including a few notes on my thought process, things I might do differently in a project with a larger scope and instructions on how to run the test.

## Notes
 - I have used Selenium, SpecFlow and C# for this solution as it's freshest in my mind
 - I have also used a page object model (although this test only required one page)
 - For the last step ("Then I can see "This field is required" under the Date of Birth box") I would normally make it more reusable by mapping the names of the fields to the "for" labels so that we could reuse that step definition for all field validations (e.g. ["Date of Birth", "dob"], ["Email Address", "map(email)"] etc). It just seemed a bit overkill for this particular test but I thought I'd mention it. 
 - I was originally worried because the test takes a long time to run, however I realised that it's the page taking a long time to finish loading.
 
 ## Instructions to run: 
 Open solution in Visual Studio, right click on it, and select "Run tests"
