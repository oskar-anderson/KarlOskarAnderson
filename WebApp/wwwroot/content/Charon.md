---
{
    "Title": "Charon",
    "Description": "Worked in an agile team at TalTech to improve functionality of Moodle plugin for programming assignments that is used by about 1000 students every semester. Charon allows teachers to track coding submissions and defenses, manage grading and provide feedback.",
    "TechStack": [
        "Laravel", 
        "PHP", 
        "Vue",
        "JS",
        "MariaDb",
        "REST",
        "Moodle API"
    ],
    "Links": [
        {
            "Display": "IT doc",
            "Href": "https://ained.pages.taltech.ee/it-doc/moodle/charon/index.html"
        }
    ],
    "Image":
    {
        "Src": "/img/charon-popup-with-favicon.png",
        "Alt": "Charon popup"
    },
    "ReadMoreLink": "Posts/Charon"
}
---
Charon is a plugin for integrating Moodle learning management system with an automated tester for managing student programming assignments submissions, feedback, defense registrations and grading.
This plugin is used actively by TalTech programming teachers, teacher assistants and students.

When students commit into their repository a git hook sends a request to Charon that will forward it to a tester.
The tester runs the student code against teachers tests that will return info on passed tests and code style back to Charon backend where it will be processed and saved into a database.
The students may then have to defend their assignments to receive a grade.

The tech stack consist of a Laravel backend that glues together Moodle API via Blade views with Charon Vue frontend.
The backend mainly provides APIs for communication between MariaDb and Vue frontend, but also handles interacting with Moodle system and sending out emails.
The frontend is mostly done in Vue. Frontend provides a grading environment for teachers to check student submissions along with attached files, leave comments and give points.
The frontend provides a better user experience then would be available through Moodle itself, by showing submission data about single student.

This system was built initially as a bachelors degree thesis in 2017. 
You can read more about it [here](https://digikogu.taltech.ee/et/item/b628d504-57e3-4d90-9c60-4bcd6bea3d61).

### What I did

I was part of an 5 member Fullstack agile development team implementing new features and fixing bugs.

Our work process was divided into 2 week sprints.
Here is a list of features developed during the sprints/epics:

* Provide a way to implement feature based Charon configuration options for users marked as moderators. This speed up product release cycle as the release process no longer has to go through Moodle team and bigger epics could now be release partially.
* Reduce number of messages generated when leaving feedback and grading students to improve overall message quality.
