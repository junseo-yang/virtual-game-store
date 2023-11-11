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

driver.find_element(By.ID, "input-search").send_keys("counter")
driver.find_element(By.ID, "search-submit").click()

game_index = [i for i, e in enumerate(driver.find_elements(By.TAG_NAME, "td")) if e.text == 'Counter-Strike 2'][0]

element = driver.find_element(By.XPATH, f"/html/body/div/main/div/div[2]/table/tbody/tr[{game_index // 5 + 1}]/td[1]")


"""
Assert
"""
assert element.text == "Counter-Strike 2"