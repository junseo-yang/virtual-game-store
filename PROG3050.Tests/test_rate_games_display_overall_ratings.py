from selenium import webdriver
from selenium.webdriver.common.by import By
import chromedriver_autoinstaller
from selenium.webdriver.common.alert import Alert
from selenium.webdriver.support.select import Select


chromedriver_autoinstaller.install()  # Check if the current version of chromedriver exists
                                      # and if it doesn't exist, download it automatically,
                                      # then add chromedriver to path

"""
Arrange
"""
driver = webdriver.Chrome()
driver.get("https://localhost:7239/")

# Login
driver.find_element(By.LINK_TEXT, "Login").click()
driver.find_element(By.ID, "Input_Email").send_keys("Moderator")
driver.find_element(By.ID, "Input_Password").send_keys("Moderator123!@")

driver.find_element(By.ID, "login-submit").click()

# Navigate to Games
driver.find_element(By.ID, "nav-game").click()

"""
Act
"""
# Find the Ratings Field
element = driver.find_element(By.XPATH, "//*[contains(text(),'Ratings')]")

"""
Assert
"""
assert element.text == 'Ratings'

"""
Clean up
"""
driver.quit()