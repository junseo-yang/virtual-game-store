from selenium import webdriver
from selenium.webdriver.common.by import By
import chromedriver_autoinstaller


chromedriver_autoinstaller.install()  # Check if the current version of chromedriver exists
                                      # and if it doesn't exist, download it automatically,
                                      # then add chromedriver to path

"""
Arrange
"""
driver = webdriver.Chrome()
driver.get("https://localhost:7239/")

"""
Act
"""
# Login
driver.find_element(By.LINK_TEXT, "Login").click()
driver.find_element(By.ID, "Input_Email").send_keys("Tester1")
driver.find_element(By.ID, "Input_Password").send_keys("Tester1!@")

driver.find_element(By.ID, "login-submit").click()

# Navigate to Games
driver.find_element(By.ID, "nav-game").click()

# Select a Game
game_title_on_index = driver.find_element(By.XPATH, "/html/body/div/main/div/div[2]/table/tbody/tr[1]/td[1]").text
driver.find_element(By.XPATH, '/html/body/div/main/div/div[2]/table/tbody/tr[1]/td[6]/a').click()
game_title_on_detail = driver.find_element(By.ID, "text_title").text

"""
Assert
"""
assert game_title_on_index == game_title_on_detail