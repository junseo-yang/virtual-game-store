from selenium import webdriver
from selenium.webdriver.common.by import By
import chromedriver_autoinstaller


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

"""
Act
"""
# Tester1 navigates to the games page
driver.get("https://localhost:7239/Games")

# Tester1 clicks a game
driver.find_element(By.XPATH, "/html/body/div/main/div/div[2]/table/tbody/tr[1]/td[6]/a").click()

# Get the previous game title
prev_title = driver.find_element(By.ID, 'text_title').text

# Tester1 clicks a recommended game
driver.find_element(By.XPATH, "/html/body/div/main/div/div/table/tbody/tr[1]/td").click()

# Get current title
cur_title = driver.find_element(By.ID, 'text_title').text

"""
Assert
"""
assert prev_title != cur_title


"""
Clean up
"""
# Logout
driver.find_element(By.ID, "dropdownMenuButton1").click()
driver.find_element(By.CSS_SELECTOR, ".btn-link").click()

driver.quit()