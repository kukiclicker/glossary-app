using BusinessLogic.Interfaces;
using Glossary.Enums;
using Glossary.Exceptions;
using Glossary.Interfaces;
using GlossaryForm.Interfaces;
using System;
using System.Windows.Forms;

namespace GlossaryForm
{
    public partial class GlossaryForm : Form
    {
        private readonly IGlossaryBusiness glossaryBusiness;
        private readonly ITermValidation termValidation;
        private readonly IDefinitionValidation definitionValidation;

        public GlossaryForm(IGlossaryBusiness _glossaryBusiness,ITermValidation _termValidation, IDefinitionValidation _definitionValidation)
        {
            glossaryBusiness = _glossaryBusiness;
            termValidation = _termValidation;
            definitionValidation = _definitionValidation;
            InitializeComponent();
            RefreshDatagrid();
            DisplayNumberOfTerms();
        }
        //Event methods
        private void ButtonFindTerm_Click(object sender, EventArgs e)
        {
            FindTerm();
        }
        private void ButtonAddTerm_Click(object sender, EventArgs e)
        {
            AddTerm();
        }
        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            UpdateTerm();
        }
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            DeleteTerm();
            RefreshDatagrid();
        }
        private void TextBoxNewDefinition_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddTerm();
                
            }
        }
        private void TextBoxTermToSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FindTerm();
            }
        }
        private void TextBoxNewTerm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddTerm();

            }
        }
        private void DataGridViewGlossary_DataSourceChanged(object sender, EventArgs e)
        {
            DisplayNumberOfTerms();
        }
        //CRUD methods
        private void AddTerm()
        {
            var term = textBoxNewTerm.Text.Trim();
            var definition = textBoxNewDefinition.Text.Trim();
            try
            {
                ValidateTerm(term);
                ValidateDefinition(definition);
                var glossary = glossaryBusiness.CreateGlossary(term, definition);
                var message = "New glossary added!";
                if (glossary == null)
                    throw new NullReferenceException("Eror while trying to add term!");
                glossaryBusiness.Insert(glossary);
                MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshDatagrid();
                ClearAddTermFields();
                RedirectToNavigationTab((int)NavigationMenuTab.GLOSSARY);
            }
            catch(NullReferenceException nullReferenceException) {
                MessageBox.Show(nullReferenceException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException argumentException)
            {
                MessageBox.Show(argumentException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (EmpthyTermException empthyTermException)
            {
                MessageBox.Show(empthyTermException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidTermException invalidTermException)
            {
                MessageBox.Show(invalidTermException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxNewTerm.Clear();
            }
            catch (EmpthyDefinitionException empthyDefinitionException)
            {
                MessageBox.Show(empthyDefinitionException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidDefinitionException invalidDefinitionException)
            {
                MessageBox.Show(invalidDefinitionException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateTerm()
        {
            string term = textBoxTermToUpdate.Text.Trim();
            string definition = textBoxUpdateDefinition.Text;
            try
            {
                ValidateTerm(term);
                ValidateDefinition(definition);
                var glossary = glossaryBusiness.CreateGlossary(term, definition);
                glossaryBusiness.Update(glossary);
                string message = "Term updated successfuly!";
                MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxTermToUpdate.Clear();
                textBoxUpdateDefinition.Clear();
                RefreshDatagrid();
                RedirectToNavigationTab((int)NavigationMenuTab.GLOSSARY);
            }
            catch (EmpthyTermException empthyTermException)
            {
                MessageBox.Show(empthyTermException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidTermException invalidTermException)
            {
                MessageBox.Show(invalidTermException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (EmpthyDefinitionException empthyDefinitionException)
            {
                MessageBox.Show(empthyDefinitionException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidDefinitionException invalidDefinitionException)
            {
                MessageBox.Show(invalidDefinitionException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(ArgumentException argumentException)
            {
                MessageBox.Show(argumentException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void DeleteTerm()
        {
            DataGridViewCell selectedCell = dataGridViewGlossary.SelectedRows[0].Cells[0];
            try
            {
                if (selectedCell == null)
                {
                    throw new RowNotSelectedException("No rows selected for deletion!");
                }
                string term = selectedCell.Value.ToString();
                var confirmMessage = $"Are you sure you want to delete term {term}";
                var result = MessageBox.Show(confirmMessage, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    glossaryBusiness.Delete(term);
                    var message = "Glossary deleted successfully!";
                    MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(RowNotSelectedException rowNotSelectedException)
            {
                MessageBox.Show(rowNotSelectedException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
        public void FindTerm()
        {
            textBoxSearchedDefinition.Clear();
            string term = textBoxTermToSearch.Text.Trim();
            try
            {
                ValidateTerm(term);
                string definition = glossaryBusiness.GetDefinitionByTerm(term);
                if (string.IsNullOrEmpty(definition))
                {
                    string message = "Term not found! Do you want to add it?";
                    var result = MessageBox.Show(message, "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (result == DialogResult.Yes)
                    {
                        RedirectToNavigationTab((int)NavigationMenuTab.ADD_TERM);
                        textBoxNewTerm.Text = term;
                        textBoxTermToSearch.Text = "";
                    }
                    if (result == DialogResult.No)
                    {
                        textBoxTermToSearch.Clear();
                    }
                }
                else
                {
                    definition = $"{term.ToLower()} - {definition}";
                    textBoxSearchedDefinition.Text = definition;
                    textBoxTermToSearch.Clear();
                }
            }
            catch (EmpthyTermException empthyTermException)
            {
                MessageBox.Show(empthyTermException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidTermException invalidTermException)
            {
                MessageBox.Show(invalidTermException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxTermToSearch.Clear();
            }
            
        }
        //Helper methods
        public void RefreshDatagrid()
        {
            dataGridViewGlossary.DataSource = glossaryBusiness.GetAll(); 
        }
        private void ClearAddTermFields()
        {
            textBoxNewTerm.Clear();
            textBoxNewDefinition.Clear();
        }
        private void RedirectToNavigationTab(int index)
        {
            tabControlNavigationMenu.SelectTab(index);
        }
        private void DisplayNumberOfTerms()
        {
            labelNumberOfTerms.Text = glossaryBusiness.NumberOfTerms().ToString();
        }
        //Validation Methods
        public void ValidateTerm(string term)
        {
            bool termEmpthy = termValidation.IsFieldEmpthy(term);
            bool termIsValid = termValidation.IsFieldValid(term);
            
            if (termEmpthy)
            {
                string message = "Term can't be empthy!";
                throw new EmpthyTermException(message);
            }
            if (!termIsValid)
            {
                string message = "Invalid term! You entered invalid characters.";
                throw new InvalidTermException(message);
            }
        }
        private void ValidateDefinition(string definition)
        {
            bool definitionIsEmpthy = definitionValidation.IsFieldEmpthy(definition);
            bool definitionIsValid = definitionValidation.IsFieldValid(definition);
            if (definitionIsEmpthy)
            {
                string message = "Definition can't be empthy!";
                throw new EmpthyDefinitionException(message);
            }
            if (!definitionIsValid)
            {
                string message = "Invalid definition! You entered invalid characters.";
                throw new InvalidDefinitionException(message);
            }
        }
    }
}
