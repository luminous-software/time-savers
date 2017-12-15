/// <binding AfterBuild='build' />
'use strict';

var gulp = require('gulp');
var gat = require('gulp-all-tasks')();
var ghPages = require('gulp-gh-pages');
var exec = require('child_process').exec;
//var exec = require('gulp-exec');

var config = {
    repo: 'https://github.com/luminous-software/time-savers.git',
    remote: 'github',
    branch: 'master',
    folder: 'site',
    push: 'false',
    force: 'false',
    //commit: 'Automatic commit text',
    user: {
        email: 'yd@live.com.au',
        name: 'Yann Duran'
    }
}

var script = {
    build: 'mkdocs build',
    serve: 'mkdocs serve --dev-addr=127.0.0.1:8003',
    //deploy: 'mkdocs gh_pages',

    changes: 'git log -n 1 HEAD --pretty=format:"  * %s"',
    log: 'git log HEAD --pretty=format:"  * %s"',
}

gulp.task('log', function (cb) {
    exec(script.log, function (err, stdout, stderr) {
        console.log(stdout);
        console.log(stderr);
        cb(err);
    })
});

gulp.task('changes', function (cb) {
    exec(script.changes, function (err, stdout, stderr) {
        console.log(stdout);
        console.log(stderr);
        cb(err);
    })
});

gulp.task('build', function (cb) {
    exec(script.build, function (err, stdout, stderr) {
        console.log(stdout);
        console.log(stderr);
        cb(err);
    })
});

gulp.task('serve', function (cb) {
    exec(script.serve, function (err, stdout, stderr) {
        console.log(stdout);
        console.log(stderr);
        cb(err);
    })
});

//gulp.task('deploy', ['build'], function () { // removes custom domain
//    return gulp.src('/**/*')
//        .pipe(ghPages({
//            remoteUrl: config.repo,
//            remote: config.remote,
//            branch: config.branch
//        }));
//});

gulp.task('default', ['build', 'deploy']);
