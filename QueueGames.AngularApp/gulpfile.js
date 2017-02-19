var gulp = require('gulp');
var concat = require('gulp-concat'); 
var rename = require('gulp-rename');
var uglify = require('gulp-uglify');

gulp.task('default', function() {
  // place code for your default task here
});

gulp.task("move:HTML", function () {
	gulp.src("app/**/*.html")
		.pipe(gulp.dest("dist/view/"));
});

gulp.task("move:CSS", function() {
	gulp.src("Content/*.css")
		.pipe(gulp.dest("dist/Content/"));
});

gulp.task("minify", function() {
	return gulp.src("/app/app.js")
	.pipe(concat('deploy.js'))
	.pipe(uglify())
	.pipe(rename({ extname: '.min.js' }))
	.pipe(gulp.dest("dist/"));
});

gulp.task("deploy", ["move:HTML", "move:CSS", "minify"]);