<div>
  <h1 align="left">TimuOn</hi>
  <img src="logo.jpeg" align="right" width=14%>
</div>

TimuOn is an integrated and centralised time management application for individuals and groups. Every user is either independent or a member of one or more organisations, within which they are assigned roles. The application incorporates meeting arrangement, room scheduling and announcements into standard calendar functionalities. It is an attempt to resolve a prominent issue that arises in modern societies: fast-paced everyday life and an overabundance of commitments render proper time management essential.

This application is being implemented as part of a mandatory project of the Software Engineering course (CEID_NΥ232), offered in the academic year 2020-21 by the Department of Computer Engineering and Informatics of the University of Patras in Greece. Thus, the scope of the original idea has been narrowed to a solution catering to Greek tertiary education institutions.

## Installation Instructions

0. Ensure that there are about 15 GB of available space on your local drive.
1. Install Microsoft Visual Studio 2019. When prompted, select the "Universal Windows Platform development" workload.
2. Launch Visual Studio, choose the option "Clone a repository" and paste the link <https://github.com/timuon/TimuOn.git>.
3. When the project has been set up, open the Configuration Manager tool, select the "Release" configuration and the "x64" platform, make sure that the options "Build" and "Deploy" are enabled for the Timuon project and close the manager window.
4. Set "Local Machine" as the build target and click on the play button.
5. Go make a cup of coffee, this is going to take a while... But the app is worth the wait, we promise!
6. Test the app! More info on what you can do as of release 1.0 can be found in the next section.


## User Guide

There are four user types: Organization, Administrator, Coordinator and Student.

### Organization

A member of the administrative staff of a university. Our dummy user is employed at the University of Patras.

- Log in with the username "<span>upatras@upatras.gr</span>" and the password "upatras".
- The home page shows an overview of important upcoming events and meetings.
- The events page allows the user to enter new events in the system, or edit/delete already existing ones and optionally notify the administrative staff of each department.
- In the schedule page, the user can change the availability of any of the auditoriums available to the organisation and schedule official holidays. There is also the option to notify the administrative staff of each department.

### Administrator

A member of the administrative staff of a department. Our dummy user is employed at the Department of Computer Engineering and Informatics.

- Log in with the username "<span>secretary@upatras.gr</span>" and the password "secretary".
- The home page shows an overview of the day's scheduled events and allows the user to enter new events in the system and optionally notify other department members about them.
- The system constraints page shows an overview of the auditoriums available to the department and the (permanent) lecture rescheduling requests made by students. The admin can edit the properties of any auditorium, add a new auditorium and resolve any of the requests.

### Coordinator

A university professor. Our dummy user is employed at the Department of Computer Engineering and Informatics.

- Log in with the username "<span>professor@upatras.gr</span>" and the password "professor".
- The home page shows an overview of the day's courses, reminders, meetings and other tasks.
- In the courses page, the professor can view the courses that they teach during the current semester request to schedule extra lectures, as well as cancel a regular lecture.
- The profile page displays the professor's personal details, courses and registered office hours. 

### Student

A university student. Our dummy user is enrolled at the University of Patras.

- Log in with the username "<span>student@upatras.gr</span>" and the password "student".
- The home page shows an overview of the day's courses, reminders and meetings.
- In the courses page, the student can add a new course to their schedule and send a notice to a professor that they are unable to participate in a specific lecture.
- In the schedule page, the user has the options to view their schedule on a selected date and arrange to meet with another user during the time periods that they are both available (according to the app).

### User Experience

The User Experience section is identical for every user type, as it contains all of the personalisation settings associated with data sources, such as external accounts, and notification settings.

- Log in with any of the four sets of credentials.
- The log tab shows an overview of the user's subscription history and provides the with the option to choose what kind of history is saved, if and when it should be deleted and whether to back it up to a cloud drive.
- The subscriptions tab contains a searchable list of the channels that the user has subscribed to, as well as a list of trending channels.
- The calendar tab enables the user to set activity preferences for studying and notifications, view and resolve any conflicts in his schedule and add new calendar services to be integrated into his account in the system.
- The RSS feed tab allows the user to view the RSS feeds they are currently following, as well as the Eclass and other platform accounts they have integrated into their TimuOn account. They can also add new feeds and connect more accounts.

The settings menu entry contains the standard sections "Colour Theme" and "About this application".

---

### Contributors

* Androutsos Labros | 1054396
* Androutsopoulos Aristeidis | 1054274
* Kavvadias Panagiotis | 1054350
* Lykothanasi Kalliopi-Klelia | 1054352
