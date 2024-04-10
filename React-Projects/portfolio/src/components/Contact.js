export default function Contact() {
    return (
        <section id="contact"
                 className="my-40 align-center max-w-5xl mx-auto p-3">
            <h2 className="text-5xl font-bold text-emerald-500 text-center">
                Contact
            </h2>
            <div className="flex gap-5 justify-center 
                        my-10">
                <a rel="noreferrer"
                   target="_blank"
                   className="text-center hover:underline"
                   href=
"https://www.linkedin.com/in/hannah-narme-b57493231/">
                    LinkedIn:
                    <span className="font-bold">
                    &nbsp;Hannah Narme
                    </span>
                </a>
                <a>
                    Email:
                    <span className="font-bold">
                    &nbsp;hnarme@ymail.com
                    </span>
                </a>
                <a>
                    Phone: 
                    <span className="font-bold">
                    &nbsp;07756015634
                    </span>
                </a>
            </div>
        </section>
    );
}