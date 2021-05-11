# setup packages
cd ComputerVision
pip install -r requirements.txt

# add images to data dir

# extract sift features of pictures in data dir
python insert.py -d data

# search image ant_0004.jpg in data dir
python search.py -i data/airplane_0004.jpg