# Bootstrap 5 Custom Styling
RetroGG.net uses Bootstrap 5 Beta as a base for its styling.

## Build Custom Styling (and view a kitchen sink with all Bootstrap elements)
> Prerequisites:
> * Bootstrap 5 Sass Source
> * Node.js (UP TO MAJOR VERSION 14, 15 IS BROKEN AT THE MOMENT)
> * Yarn (`npm install -g yarn`)
1. Put the Bootstrap 5 Sass source into bs-scss such that `bootstrap.scss` is directly in bs-scss along with all the
   other core SCSS files, and subfolders.
2. Execute `yarn install` or just `yarn` inside the nested RetroGG.net folder, at the level of `yarn.lock`
   and `package.json`.
3. Now run `yarn gulp scss` (Only builds SCSS) or just `yarn gulp` (Builds SCSS and starts a kitchen sink of Bootstrap
   elements). You're done with the setup! If you want to change the styling, read on...

## Change Custom Styling
Just edit the variables or styles in `_variables.scss` or `_styles.scss` respectively.
If you run `yarn gulp` while changing, it will update your kitchen sink as you save, as it uses a watcher.

## Take Changes into Effect
The output `retrogg.css` does not automatically get copied into wwwroot, you must copy it directly into
wwwroot/css/retrogg-bs/ for it to take effect on the main site.
