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

# Navigate to the first game detail page
driver.find_element(By.XPATH, "/html/body/div/main/div/div[2]/table/tbody/tr[1]/td[6]/a").click()

# Write a review and Rate the game
driver.find_element(By.ID, "Title").send_keys("Test Review 1")
driver.find_element(By.ID, "Description").send_keys("Test Description 1")
driver.find_element(By.ID, "btnWriteReview").click()

# Navigate to Reviews
driver.get('https://localhost:7239/Reviews')

"""
Act
"""
# Get index of Test Review 1
test_review_index = [i for i, e in enumerate(driver.find_elements(By.TAG_NAME, "td")) if e.text == 'Test Review 1'][0]
driver.find_element(By.XPATH, f"/html/body/div/main/table/tbody/tr[{test_review_index//7 + 1}]/td[7]/a[1]").click()

# Update to Processed status
select = Select(driver.find_element(By.ID, 'Status'))
select.select_by_visible_text('Processed')
driver.find_element(By.XPATH, "/html/body/div/main/div[1]/div/form/div[7]/input").click()

# Navigate to Games
driver.find_element(By.ID, "nav-game").click()

# Navigate to the first game detail page
driver.find_element(By.XPATH, "/html/body/div/main/div/div[2]/table/tbody/tr[1]/td[6]/a").click()

"""
Assert
"""
element = driver.find_element(By.XPATH, "//*[text()='Test Review 1']")
assert element.text == 'Test Review 1'

"""
Clean up
"""
# Navigate to Reviews
driver.get('https://localhost:7239/Reviews')

# Get index of Test Review 1
test_review_index = [i for i, e in enumerate(driver.find_elements(By.TAG_NAME, "td")) if e.text == 'Test Review 1'][0]

# Click Delete
driver.find_element(By.XPATH, f"/html/body/div/main/table/tbody/tr[{test_review_index//7 + 1}]/td[7]/a[3]").click()
driver.find_element(By.XPATH, f"/html/body/div/main/div/form/input[2]").click()
driver.refresh()
driver.quit()