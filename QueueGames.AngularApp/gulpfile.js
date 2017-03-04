var gulp = require('gulp');
var concat = require('gulp-concat'); 
var rename = require('gulp-rename');
var uglify = require('gulp-uglify');
var cleancss = require('gulp-clean-css');

gulp.task('default', ["move:HTML", "minify:CSS", "minify:js"]);

gulp.task("move:HTML", function () {
	gulp.src("app/**/*.html")
		.pipe(gulp.dest("dist/app/"));
});

gulp.task("minify:CSS", function() {
	gulp.src("Content/Site.css")
        .pipe(rename({basename: 'deploy', suffix: '.min'}))
        .pipe(cleancss())
		.pipe(gulp.dest("dist/Content/"));
});

gulp.task('minify:js', function() {
  gulp.src(['app/app.js', 'app/app.config.js', 'app/components/**/*.js', 'app/directive/**/*.js', 'app/shared/**/*.js'])    
    .pipe(concat('deploy.js'))
        .pipe(rename({suffix: '.min'}))
        .pipe(uglify())
        .pipe(gulp.dest('dist/js'));
});