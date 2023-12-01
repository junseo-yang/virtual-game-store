from selenium import webdriver
import chromedriver_autoinstaller
from selenium.webdriver.common.by import By
from selenium.webdriver.common.alert import Alert
import os
import time


chromedriver_autoinstaller.install()  # Check if the current version of chromedriver exists
                                      # and if it doesn't exist, download it automatically,
                                      # then add chromedriver to path

"""
Arrange
"""
# Tester1 navigates to the homepage
driver = webdriver.Chrome()
driver.get("https://localhost:7239/")

# Tester1 login
driver.find_element(By.LINK_TEXT, "Login").click()
driver.find_element(By.ID, "Input_Email").send_keys("Tester1")
driver.find_element(By.ID, "Input_Password").send_keys("Tester1!@")
driver.find_element(By.ID, "login-submit").click()

# Tester1 navigates to the download page
driver.get("https://localhost:7239/DownLoad")

"""
Act
"""
# Tester1 tries to download the free game
driver.find_element(By.XPATH, "/html/body/div/main/table[1]/tbody/tr[1]/td[2]/button").click()

# Wait for some time to ensure the download is complete
time.sleep(5)


"""
Assert
"""
# Check if the file exists in the Downloads folder
download_folder = os.path.expanduser("~") + "\Downloads"

# Assume the file name is "Counter-Strike 2.txt" for the free game
file_name = "Counter-Strike 2.txt"
file_path = os.path.join(download_folder, file_name)

assert os.path.exists(file_path), f"File '{file_name}' not found in the Downloads folder."

# Open the file with the default text editor
os.system(f'start "" "{file_path}"')

# """
# Clean up
# """
# # delete the downloaded file
# os.remove(file_path)
