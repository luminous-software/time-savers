## What's Luminous Code?

*Luminous Code* is a collection of projects, namespaces, classes, methods, and extention methods,
that I wrote to keep the code that I need to write in my various projects as **DRY** as possible! 
It's driven by my own needs as a developer,
but I'm more than happy to share it with anyone who might find it useful,
and to accept suggestions, pull requests or bug reports.

I just don't understand why anyone would want to write the same old low-level code to accomplish a particular task each
and every time they need it?
Unfortunately, the practice is a lot more common than you might think!
Well I don't know about you, but I **hate** maintaining code like that.

Whenever I find myself writing the same code again, I first extract it into a new class or a new method,
as a lot of experienced developers will do.
Then as soon as I can, I'll transfer the code to the appropriate *Luminous Code* namespace so that I can reuse it myself,
and also release it for others to benefit from as well.

Also, if it's taken me some time to figure out how to do something **new**, I'll add it into the framework too.
That way I'm not constantly reinventing the wheel, so to speak. I figure it out **once**, not **every**
time I need the same task done.

## Clear and Obvious Intent

It isn't really all that easy to understand what multiple lines of low-level code are actually
designed to accomplish when you come back to the code days, weeks, months, or even years later!
Without working your way through each line, you have no real idea what the *intent* of the code is.

Which lines of code would you rather be maintaining?

<example>(example goes here)</example>

The *intent* of any code that you write should be **clear** and **obvious** to anyone who is using or maintaining
your code (even if it's you). 
One of the main reasons that I wrote the *Luminous Code* was so I could use code that has **clear and obvious intent**.

## Summary

Luminous Code helps you to:

* keep your code as DRY as possible
* write code that is more easily maintained
* write code that has clear and obvious intent

## Future Development

If you happen to find *Luminous Code* useful and would like to support future development,
maybe you could shout me a coke (as I don't actually drink coffee or beer, lol).

[![Donate][donate-img-au]][paypal-me]

---

## Contribute

Check out the [contribution guidelines][contribute-url]
if you want to contribute to this project. I'd **love** to see others in the community adding
code as long as it meets the project's goals.

For cloning and building this project yourself, make sure to install the
[Extensibility Tools 2015][extensibility-tools-url]
extension for Visual Studio which enables some features used by this project.

## License

[![License][license-img]][license-url]

---

[donate-img-au]: https://www.paypalobjects.com/en_AU/i/btn/btn_donateCC_LG.gif
[paypal-me]: https://www.paypal.me/yannduran/5
[contribute-url]: https://github.com/luminous-software/luminous-code/blob/master/.github/CONTRIBUTING.md
[extensibility-tools-url]: https://visualstudiogallery.msdn.microsoft.com/ab39a092-1343-46e2-b0f1-6a3f91155aa6
[license-img]: https://img.shields.io/:license-mit-blue.svg?style=flat-square
[license-url]: https://yannduran.mit-license.org