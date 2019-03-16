from __future__ import print_function

import os,shutil,glob

prjdir = "TrivialBehinds"
version = "1.2"
def c(s):
    print(">",s)
    err = os.system(s)
    assert not err

def nuke(pth):
    if os.path.isdir(pth):
        shutil.rmtree(pth)

def rm_globs(*globs):
    for g in globs:
        files = glob.glob(g)
        for f in files:
            print("Del",f)
            os.remove(f)

nuke(prjdir + "/bin")
nuke(prjdir + "/obj")
os.chdir(prjdir)
c("dotnet pack /p:PackageVersion=%s -c Release" % version)
