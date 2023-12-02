from selenium import webdriver
from selenium.webdriver.common.by import By
import chromedriver_autoinstaller
from selenium.webdriver.common.alert import Alert


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
driver.find_element(By.ID, "Input_Email").send_keys("Tester2")
driver.find_element(By.ID, "Input_Password").send_keys("Tester2!@")

driver.find_element(By.ID, "login-submit").click()

# Navigate to Games
driver.find_element(By.ID, "nav-game").click()

# Add a Game to wishlist
game_title_on_index = driver.find_element(By.XPATH, "/html/body/div/main/div/div[2]/table/tbody/tr[1]/td[1]").text
driver.find_element(By.XPATH, '/html/body/div/main/div/div[2]/table/tbody/tr[1]/td[6]/input').click()

# Navigate to WishList
driver.get('https://localhost:7239/Wishlist')

element = driver.find_elements(By.TAG_NAME, "td")[0]

"""
Assert
"""
assert element.text == game_title_on_index

"""
Clean up
"""
# Delete the added game
driver.find_element(By.XPATH, '/html/body/div/main/table/tbody/tr/td[3]/div/form/button').click()
Alert(driver).accept()
driver.refresh()
driver.quit()