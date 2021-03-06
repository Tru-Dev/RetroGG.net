var gulp = require('gulp');
var browserSync = require('browser-sync').create();
var sass = require('gulp-sass');

// Compile sass into CSS & auto-inject into browsers
gulp.task('sass', function () {
    return gulp.src("bs-theming/scss/*.scss")
        .pipe(sass())
        .pipe(gulp.dest("bs-theming/css"))
        .pipe(browserSync.stream());
});

// Static Server + watching scss/html files
gulp.task('serve', gulp.series('sass', function () {

    browserSync.init({
        server: "./bs-theming/"
    });

    gulp.watch("bs-theming/scss/*.scss", gulp.series('sass'));
    gulp.watch("bs-theming/*.html").on('change', browserSync.reload);
}));

gulp.task('default', gulp.series('serve'));
