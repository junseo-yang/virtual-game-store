<a name="readme-top"></a>

<!-- PROJECT SHIELDS -->
<!--
*** I'm using markdown "reference style" links for readability.
*** Reference links are enclosed in brackets [ ] instead of parentheses ( ).
*** See the bottom of this document for the declaration of the reference variables
*** for contributors-url, forks-url, etc. This is an optional, concise syntax you may use.
*** https://www.markdownguide.org/basic-syntax/#reference-style-links
-->
[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![MIT License][license-shield]][license-url]
[![LinkedIn][linkedin-shield]][linkedin-url]


<!-- PROJECT LOGO -->
<br />
<div align="center">
  <a href="https://github.com/junseo-yang/virtual-game-store">
    <img src="img/logo.png" alt="Logo" width="80" height="80">
  </a>

<h3 align="center">Virtual Game Store</h3>

  <p align="center">
    A Virtual Game Store App
    <br />
    <a href="https://github.com/junseo-yang/virtual-game-store"><strong>Explore the docs »</strong></a>
    <br />
    <br />
    <a href="https://github.com/junseo-yang/virtual-game-store">View Demo</a>
    ·
    <a href="https://github.com/junseo-yang/virtual-game-store/issues">Report Bug</a>
    ·
    <a href="https://github.com/junseo-yang/virtual-game-store/issues">Request Feature</a>
  </p>
</div>



<!-- TABLE OF CONTENTS -->
<details>
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
      <ul>
        <li><a href="#built-with">Built With</a></li>
      </ul>
    </li>
    <li>
      <a href="#getting-started">Getting Started</a>
      <ul>
        <li><a href="#prerequisites">Prerequisites</a></li>
        <li><a href="#installation">Installation</a></li>
      </ul>
    </li>
    <li><a href="#usage">Usage</a></li>
    <li><a href="#roadmap">Roadmap</a></li>
    <li><a href="#contributing">Contributing</a></li>
    <li><a href="#license">License</a></li>
    <li><a href="#contact">Contact</a></li>
    <li><a href="#acknowledgments">Acknowledgments</a></li>
  </ol>
</details>



<!-- ABOUT THE PROJECT -->
## About The Project
[![Product Screen Shot Home][product-screenshot-home]](https://github.com/junseo-yang/virtual-game-store)

🚀 Introducing "Insider Club" - Your Ultimate Gaming Hub! 🎮  

Are you ready to take your gaming experience to the next level?  

Join the "Insider Club" – the hottest online gaming community brought to you by CVGS! 🌐 

--- 

🔒 Members-Only Access:  

Unlock exclusive features and be part of a gaming community like never before! Gain access to personalized game recommendations, member-only events, and much more! 

---

🌟 Member Benefits:  

✅ Personalized Profiles:  

Customize your profile with your actual name, gender, and birthdate.  

✉️ Email Preferences: Choose to receive promotional emails and stay in the loop with the latest gaming news from CVGS.  

⚙️ Preferences Center:  

Indicate your favorite platforms, game categories, and language preferences for a tailor-made gaming experience. 

---

🌐 Connect with Friends and Family:  

🤝 Friends & Family List:  

Add your gaming buddies and share your wishlists with them!  

👀 View Wishlists:  

Explore what your friends are eyeing and share your wishlist on social media.  

🌟 Rate & Review Games:  

Express your thoughts on games and discover what others are playing. 

---

🎮 Game Selection Made Easy: 

🔍 Search & Select: 

Find your favorite games effortlessly.  

🛒 Shopping Cart: 

Create your personalized cart, add games, and check out securely with registered credit cards. 

📦 Order Processing:  

Track your orders, and if applicable, get physical copies shipped right to your doorstep! 

--- 

📅 Stay Updated with Events:  

📆 Event Registration: 

Don't miss out on upcoming gaming events – register seamlessly within the "Insider Club"! 

---

💻 For CVGS Employees:  

🔧 Admin Panel: Manage games, events, reviews, and reports effortlessly. 

---

⏩ Quick and Secure: 

💨 Fast Login: 

Log in quickly with limited consecutive attempts for enhanced security. 

🔐 Password Management: 

Change your password with ease or reset it if forgotten. 

### Project Binder
<a href="https://github.com/junseo-yang/virtual-game-store/blob/development/Project%20Binder.pdf">Project Binder.pdf</a>
[![Product Screen Shot Project Binder][product-screenshot-project-binder]](https://github.com/junseo-yang/virtual-game-store/blob/development/Project%20Binder.pdf)

### User Documentation
<a href="https://github.com/junseo-yang/virtual-game-store/blob/development/User%20Documentation.pdf">User Documentation.pdf</a>
[![Product Screen Shot User Documentation][product-screenshot-user-documentation]](https://github.com/junseo-yang/virtual-game-store/blob/development/User%20Documentation.pdf)

<p align="right">(<a href="#readme-top">back to top</a>)</p>


### Built With
* [![C#][C#]][C#-url]
* [![.NET][.NET]][.NET-url]
* [![Javascript][Javascript]][Javascript-url]
* [![Bootstrap][Bootstrap.com]][Bootstrap-url]
* [![JQuery][JQuery.com]][JQuery-url]


<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- GETTING STARTED -->
## Getting Started

This is an example of how you may give instructions on setting up your project locally.
To get a local copy up and running follow these simple example steps.

### Prerequisites
1. ASP .NET Core MVC - https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/start-mvc?view=aspnetcore-8.0&tabs=visual-studio


### Installation

1. Clone the repo
    ```sh
    git clone https://github.com/junseo-yang/virtual-game-store.git
    ```
2. Config
    1. Open up `PROG3050.sln` Solution File in Visual Studio 
    2. Open `appsettings.json` and `appsettings.Development.json`
    3. Update `DefaultConnection` according your DB Server address and Database in each json file
        ```json
        {
          "ConnectionStrings": {
            "DefaultConnection": "Server=localhost;Database=PROG3050;Trusted_Connection=True;MultipleActiveResultSets=true"
          },
          "Logging": {
            "LogLevel": {
              "Default": "Information",
              "Microsoft.AspNetCore": "Warning"
            }
          },
          "AllowedHosts": "*"
        }
        ```
3. Migration
    1. Run `Update-Database` to migrate DB
        ```sh
        Update-Database
        ```
4. Run Application in Visual Studio

<p align="right">(<a href="#readme-top">back to top</a>)</p>


<!-- ROADMAP -->
## Roadmap

- [x] Homepage
- [x] Sign up
- [x] Login
- [x] Forgotten/Reset password
- [x] Profile
- [x] Preferences
- [x] Mailing Address
- [x] Selecting Games
- [x] Game Recommendations
- [x] Wishlist
    - [x] Add
    - [x] Delete
    - [x] View others
    - [x] Share
- [x] Friend/Family
    - [x] Add
    - [x] Delete
- [x] Review/Rate
    - [x] Add
    - [x] Edit
    - [x] Delete
    - [x] Approve
- [x] Cart/Checkout
- [x] Events

See the [open issues](https://github.com/junseo-yang/virtual-game-store/issues) for a full list of proposed features (and known issues).

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- CONTRIBUTING -->
## Contributing

Contributions are what make the open source community such an amazing place to learn, inspire, and create. Any contributions you make are **greatly appreciated**.

If you have a suggestion that would make this better, please fork the repo and create a pull request. You can also simply open an issue with the tag "enhancement".
Don't forget to give the project a star! Thanks again!

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- LICENSE -->
## License

Distributed under the MIT License. See `LICENSE.txt` for more information.

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- CONTACT -->
## Contact

**Junseo Yang**
- :briefcase: LinkedIn: https://linkedin.com/in/junseo-yang
- :school_satchel: Website: https://junseo-yang.github.io
- :mailbox: jsy724724@gmail.com

Project Link: [https://github.com/junseo-yang/virtual-game-store](https://github.com/junseo-yang/virtual-game-store)

<p align="right">(<a href="#readme-top">back to top</a>)</p>


<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[contributors-shield]: https://img.shields.io/github/contributors/junseo-yang/virtual-game-store.svg?style=for-the-badge
[contributors-url]: https://github.com/junseo-yang/virtual-game-store/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/junseo-yang/virtual-game-store.svg?style=for-the-badge
[forks-url]: https://github.com/junseo-yang/virtual-game-store/network/members
[stars-shield]: https://img.shields.io/github/stars/junseo-yang/virtual-game-store.svg?style=for-the-badge
[stars-url]: https://github.com/junseo-yang/virtual-game-store/stargazers
[issues-shield]: https://img.shields.io/github/issues/junseo-yang/virtual-game-store.svg?style=for-the-badge
[issues-url]: https://github.com/junseo-yang/virtual-game-store/issues
[license-shield]: https://img.shields.io/github/license/junseo-yang/virtual-game-store.svg?style=for-the-badge
[license-url]: https://github.com/junseo-yang/virtual-game-store/blob/master/LICENSE.txt
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://linkedin.com/in/junseo-yang
[Bootstrap.com]: https://img.shields.io/badge/Bootstrap-563D7C?style=for-the-badge&logo=bootstrap&logoColor=white
[Bootstrap-url]: https://getbootstrap.com
[JQuery.com]: https://img.shields.io/badge/jQuery-0769AD?style=for-the-badge&logo=jquery&logoColor=white
[JQuery-url]: https://jquery.com
[Javascript]: https://img.shields.io/badge/JavaScript-F7DF1E?style=for-the-badge&logo=javascript&logoColor=black
[Javascript-url]: https://developer.mozilla.org/en-US/docs/Web/JavaScript
[.NET]: https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white
[.NET-url]: https://dotnet.microsoft.com/en-us/
[C#]: https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white
[C#-url]: https://learn.microsoft.com/en-us/aspnet/core/mvc/overview?view=aspnetcore-8.0
[product-screenshot-home]: img/home.png
[product-screenshot-project-binder]: img/project-binder.png
[product-screenshot-user-documentation]: img/user-documentation.png
