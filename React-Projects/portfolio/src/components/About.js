export default function About() {
    return (
        <section
            id="about"
            className="px-10 w-full flex flex-col lg:flex-row py-20 
                       align-center bg-emerald-200 max-w-5xl mx-auto">
            <div className="flex-1">
                <img src=
"https://media.geeksforgeeks.org/img-practice/Asset1-1641910145.svg"
                    alt="About"
                    className="w-full h-full bg-cover"/>
            </div>
            <div className="flex-1 flex flex-col justify-center
                            items-center gap-5 px-6">
                <div>
                    <h2 className="text-center text-emerald-500 
                                   text-5xl font-bold">
                        About Me :
                    </h2>
                </div>
                <p>
                    I am a computer science graduate. 
                    I enjoy the challenge of computing and due to technology constantly evolving there is always something new to learn.
                </p>
                <p>
                For my final year project, I created an innovative motion detection game using python and unity 3d. 
                I also created a 3d action-adventure game for university. 
                For another assignment at university, I had to develop a three-tier dynamic database-driven web application. 
                I used server-side technical knowledge covered in the module, i.e., Node.js, PHP, Laravel, MySQL, MongoDB, and combined with HTML and other front-end technologies (e.g., CSS and any templates, JavaScript.). 
                I also had to deploy my website on a host server, and I decided to use the server login details provided by my university. 
                As a passion project I am currently creating an app and a mobile game that I plan to distribute on google play store.
                </p>
            </div>
        </section>
    );
}